using PingRequester.BusinessLayer;
using PingRequester.BusinessLayer.Services;
using PingRequester.Data;
using PingRequester.Data.DataObjects;
using PingRequester.Data.Entities;

namespace PingRequester.Client
{
    /// <summary>
    /// Main Form class of the app.
    /// </summary>
    public partial class MainForm : Form, IRequestRunWidgetService
    {
        private ConsoleWriter console;
        private Requester requester;
        private bool controlsLocked;
        private Stack<Control> mainControls;
        private JsonService<Preferences> jsonServicePreferences;
        private Preferences preferences;
        private JsonService<Settings> jsonServiceSettings;
        private Settings settings;
        private LogFilesService logFilesService;
        private bool logSaved = false;
        private PingRequestData _data;
        private List<RequestRunSession> storedSessions;
        private bool sessionRowsOrderedByNewest = true;

        /// <summary>
        /// Default constructor of the MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.controlsLocked = false;
            btnSaveSession.Enabled = false;

            // create queue of main controls
            this.mainControls = new Stack<Control>();
            this.mainControls.Push(lblPingTarget);
            this.mainControls.Push(txbPingTarget);
            this.mainControls.Push(lblMode);
            this.mainControls.Push(cmbMode);
            this.mainControls.Push(lblRefreshRate);
            this.mainControls.Push(nudRefreshRate);
            this.mainControls.Push(chbInfiniteLoop);
            this.mainControls.Push(lblNumberOfPR);
            this.mainControls.Push(nudNumberOfPR);
            this.mainControls.Push(lblAttempts);
            this.mainControls.Push(nudAttempts);
            this.mainControls.Push(lblPacketSize);
            this.mainControls.Push(nudPacketSize);
            this.mainControls.Push(btnSendRequest);
            this.mainControls.Push(chbStopWhenSuccess);
            this.mainControls.Push(btnSaveSession);
            this.mainControls.Push(chbAutoSave);

            // Initialize DbService
            this._data = new PingRequestData();

            // init storedSessions
            this.storedSessions = new List<RequestRunSession>();

            // load data from configs
            this.jsonServicePreferences = new JsonService<Preferences>(PathProvider.GetWritablePath("config/PreferencesConfig.json"));
            this.preferences = jsonServicePreferences.LoadFileContent();

            this.jsonServiceSettings = new JsonService<Settings>(PathProvider.GetWritablePath("config/SettingsConfig.json"));
            this.settings = jsonServiceSettings.LoadFileContent();

            // Create services for logging data
            this.logFilesService = new LogFilesService(settings.PathToLogFiles, settings.TimeStampTemplate);

            // Prepare console writer
            this.console = new ConsoleWriter(rtbConsole, lblInfo);
            this.console.SetColorTheme(this.settings.ConsoleColorTheme);
        }

        /// <summary>
        /// Refreshes Request Run UI tab with data passed from RequestRun instance.
        /// </summary>
        /// <param name="requestRun"></param>
        public void OverwriteRequestRunUI(RequestRun requestRun)
        {
            lblSentActive.Text = requestRun.PacketsSent.ToString();
            lblRecievedActive.Text = requestRun.PacketsRecieved.ToString();
            lblLostActive.Text = requestRun.PacketsLost.ToString();
            lblMaximumActive.Text = $"{requestRun.MaxTime} ms";
            lblMinimumActive.Text = $"{requestRun.MinTime} ms";
            lblAverageActive.Text = $"{Math.Round(requestRun.AverageTime, 2)} ms";
        }

        /// <summary>
        /// Sets initial text to labels.
        /// </summary>
        private void SetInitialLabelText()
        {
            lblPingingActive.Text = "-";
            lblIpAddressActive.Text = "-";
            lblPacketSizeRRActive.Text = "-";
            lblSentActive.Text = "-";
            lblRecievedActive.Text = "-";
            lblLostActive.Text = "-";
            lblMaximumActive.Text = "- ms";
            lblMinimumActive.Text = "- ms";
            lblAverageActive.Text = "- ms";
            lblInfo.Text = "Info:";
        }

        /// <summary>
        /// Called when MainForm is created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Reset cmb
            cmbMode.Items.Clear();

            // Combo Box - items
            cmbMode.Items.Add("Aggressive");
            cmbMode.Items.Add("Precise");

            // set components
            txbPingTarget.Text = preferences.PingTarget;
            cmbMode.Text = preferences.Mode;
            nudRefreshRate.Value = (decimal)preferences.RefreshRate;
            chbInfiniteLoop.Checked = preferences.InfiniteLoop;
            chbStopWhenSuccess.Checked = preferences.StopWhenSuccess;
            nudNumberOfPR.Value = (decimal)preferences.NumberOfPR;
            nudAttempts.Value = (decimal)preferences.Attempts;
            nudPacketSize.Value = (decimal)preferences.PacketSize;
            chbAutoSave.Checked = preferences.AutoSave;

            // check for infinite loop chb state and set controls state accordingly
            SetLockOnInfiniteLoopControls();

            // set stop button state
            btnStop.Enabled = false;
        }

        /// <summary>
        /// Changes Enabled property and colors text of labels.
        /// Method operates with private bool field numberOfTriesState
        /// </summary>
        private void SetLockOnInfiniteLoopControls()
        {
            bool numberOfTriesState = !chbInfiniteLoop.Checked;

            if (numberOfTriesState)
            {
                lblAttempts.ForeColor = System.Drawing.Color.Black;
                lblNumberOfPR.ForeColor = System.Drawing.Color.Black;
                nudAttempts.Enabled = true;
                nudNumberOfPR.Enabled = true;
                chbStopWhenSuccess.Enabled = false;
            }
            else
            {
                lblAttempts.ForeColor = System.Drawing.Color.LightGray;
                lblNumberOfPR.ForeColor = System.Drawing.Color.LightGray;
                nudAttempts.Enabled = false;
                nudNumberOfPR.Enabled = false;
                chbStopWhenSuccess.Enabled = true;
            }
        }

        /// <summary>
        /// Changes Enabled property of all input controls on the left side of the UI.
        /// </summary>
        private void SetLockOnControls()
        {
            if (this.controlsLocked)
            {
                foreach (var control in this.mainControls)
                    control.Enabled = true;

                btnSaveSession.Enabled = !chbAutoSave.Checked;
            }
            else
            {
                foreach (var control in this.mainControls)
                    control.Enabled = false;
            }

            btnStop.Enabled = !btnStop.Enabled;
            this.controlsLocked = !this.controlsLocked;
        }

        private void chbInfiniteLoop_Click(object sender, EventArgs e)
        {
            SetLockOnInfiniteLoopControls();
        }

        private async void btnSendRequest_Click(object sender, EventArgs e)
        {
            // get/reload new settings
            this.settings = jsonServiceSettings.LoadFileContent();

            // reset initial label text values
            SetInitialLabelText();

            // lock controls
            SetLockOnControls();

            // clear console if enabled
            if (settings.ClearConsole)
                rtbConsole.Text = "";

            // mark logs as unsaved
            this.logSaved = false;

            // create requester
            console.LogInfo("Creating Requester.");

            requester = new Requester(this)
            {
                RequestedAddress = txbPingTarget.Text.ToLower(),
                Mode = cmbMode.Text,
                RefreshRate = (int)nudRefreshRate.Value,
                NumberOfPR = (int)nudNumberOfPR.Value,
                Attempts = (int)nudAttempts.Value,
                InfiniteLoop = chbInfiniteLoop.Checked,
                PacketSize = (int)nudPacketSize.Value,
                StopWhenSuccess = chbStopWhenSuccess.Checked,
                StopSignal = false,
                Settings = settings
            };

            // log warning if infinite loop is turned on
            if (requester.InfiniteLoop)
                console.LogWarning("Infinite loop is turned ON");

            // create request service instance
            var service = new RequestService(requester, this.console);

            // create RequestRun instance
            console.LogMessage("Initializing Request Run.");

            RequestRun requestRun = new RequestRun(this, requester.RequestedAddress, requester.PacketSize);
            requestRun.Init();
            requestRun.IPv4 = requester.RequestedAddress == "127.0.0.1" ? "127.0.0.1" : service.Hostname2Ipv4(requestRun.Hostname);
            requester.RequestRun = requestRun;

            // Write-in initial data into Request Run widgets
            lblPingingActive.Text = requestRun.Hostname;
            lblIpAddressActive.Text = requestRun.IPv4;
            lblPacketSizeRRActive.Text = requestRun.PacketSize.ToString();

            // begin sending requests
            string message = $"Seeking for {requestRun.Hostname}";

            if (!requestRun.Hostname.Equals(requestRun.IPv4))
                message += $" (ipv4={requestRun.IPv4})";

            message += $", started at: {DateTime.Now}";
            console.LogInfo(message);

            // start async. algorithm
            requestRun.Start = DateTime.Now;
            await service.BeginRequestingAsync();
            requestRun.End = DateTime.Now;

            // if session auto-save enabled
            if (chbAutoSave.Checked)
                btnSaveSession_Click(this, EventArgs.Empty);

            // requesting done
            console.LogMessage($"Pinging finished at: {DateTime.Now}");
            SetLockOnControls();
            SetLockOnInfiniteLoopControls();
            btnStop.Enabled = false;
            if (requester.Settings.AlertOnPingCompletion)
                Notifications.PingingFinished(!requester.Settings.MakeSound);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            requester.StopSignal = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PreferencesForm(this).ShowDialog();
        }

        private void tbc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Database tab
            if (tbc.SelectedIndex == 1)
            {
                var actualSessions = _data.Sessions.GetAll().OrderBy(s => s.Start);

                btnDeleteAll.Enabled = actualSessions.Count() != 0;

                RefreshSessionRowsUI();
            }

            /* A workaround for the Console (richtextbox) bug.
             * This code solves the bug when UI from Request Run tab is being displayed in the Console tab.
             * Code bellow scrolls to the top and down again in order to get rid of the wrong pixels.
             * The bug was appearing only when large number of ping requests was set.
             */

            // Console tab
            if (tbc.SelectedIndex == 2)
            {
                rtbConsole.SelectionStart = 0;
                rtbConsole.ScrollToCaret();
                rtbConsole.SelectionStart = rtbConsole.TextLength;
                rtbConsole.ScrollToCaret();
            }
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var dialogRestartNeeded = new SettingsForm().ShowDialog();

            if (dialogRestartNeeded == DialogResult.Yes)
            {
                // forced restart:
                // Application.Restart() cannot be called due to possibility of unexpected error 
                // in case there is unsaved log in the console.
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Environment.Exit(0);
            }
        }

        private void btnCopyPinging_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblPingingActive.Text);
            console.LogInfo("Pinging target copied to clipboard.", true);
        }

        private void btnCopyIPAddress_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblIpAddressActive.Text);
            console.LogInfo("IPv4 address copied to clipboard.", true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbConsole.Clear();
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            this.logSaved = true;
            this.logFilesService.Write(rtbConsole.Text);
            console.LogInfo("Log saved.", true);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // reload current settings
            this.settings = jsonServiceSettings.LoadFileContent();

            // condition
            if (settings.AskToSaveLog && rtbConsole.Text.Trim() != "" && !this.logSaved)
            {
                var dialog = new MessageBoxSaveLog(e).ShowDialog();

                if (dialog == DialogResult.OK)
                {
                    btnSaveLog_Click(this, EventArgs.Empty);
                }
            }
        }

        private void btnSaveSession_Click(object? sender, EventArgs e)
        {
            var preferences = new UserPreferences
            {
                PingTarget = txbPingTarget.Text,
                Mode = cmbMode.Text,
                RefreshRate = (int)nudRefreshRate.Value,
                InfiniteLoop = chbInfiniteLoop.Checked,
                StopWhenSuccess = chbStopWhenSuccess.Checked,
                PingRequestCount = (int)nudNumberOfPR.Value,
                Attempts = (int)nudAttempts.Value,
                PacketSize = (int)nudPacketSize.Value
            };

            var session = new RequestRunSession
            {
                Start = requester.RequestRun.Start,
                End = requester.RequestRun.End,
                PingTarget = requester.RequestRun.Hostname,
                Ipv4 = requester.RequestRun.IPv4,
                PacketSize = requester.PacketSize,
                Sent = requester.RequestRun.PacketsSent,
                Received = requester.RequestRun.PacketsRecieved,
                Lost = requester.RequestRun.PacketsLost,
                MaxResponseTimeMs = requester.RequestRun.MaxTime,
                MinResponseTimeMs = requester.RequestRun.MinTime,
                AverageResponseTimeMs = requester.RequestRun.AverageTime
            };

            _data.AddPingRequestRun(preferences, session);

            this.console.LogInfo("Session saved.", true);
        }

        /// <summary>
        /// Clears UI Control where session records are displayed and clears storedSessions variable.
        /// </summary>
        private void ResetSessionRows()
        {
            flpSessions.Controls.Clear();
            this.storedSessions.Clear();
        }

        /// <summary>
        /// Loads stored sessions into the UI control for displaying sessions.
        /// </summary>
        /// <param name="sessions"></param>
        private void LoadSessionRows(IEnumerable<RequestRunSession> sessions)
        {
            // in case no sessions were found display label
            if (sessions.Count() == 0)
            {
                var label = new Label
                {
                    Name = "lblFLPInfoLabel",
                    Text = "No records to show.",
                    Width = flpSessions.Width,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.Black,
                    Margin = new Padding(0, 20, 0, 0)
                };

                flpSessions.Controls.Add(label);
                return;
            }

            // add sessions to the flowLayoutPanel
            foreach (var session in sessions)
            {
                if (this.storedSessions.Any(s => s.Id == session.Id))
                    continue;

                Color defaultBgColor;
                int controlsCount = flpSessions.Controls.Count;

                if (controlsCount % 2 == 1)
                    defaultBgColor = Color.FromArgb(230, 230, 230);
                else
                    defaultBgColor = Color.WhiteSmoke;

                var sessionRow = new SessionRow(session, defaultBgColor);

                // add event handlers
                sessionRow.SessionDeleted += (s, args) => { RefreshSessionRowsUI(); };
                sessionRow.UsePreferences += (s, args) => { ReloadPreferences(s); };

                flpSessions.Controls.Add(sessionRow);
                storedSessions.Add(session);
            }

            // spacer to add extra spcae under the last row
            flpSessions.Controls.Add(new Panel { Name = "pnlSpacer", Height = 15, BackColor = Color.Transparent });
        }

        /// <summary>
        /// Refreshes sessions rows UI with current data
        /// </summary>
        private void RefreshSessionRowsUI()
        {
            ResetSessionRows();
            var sessions = _data.Sessions.GetAll();
            LoadSessionRows(sessions);
        }

        /// <summary>
        /// Loads user preferences from session record to the UI.
        /// </summary>
        /// <param name="s"></param>
        private void ReloadPreferences(object s)
        {
            var session = (SessionRow)s;
            var userPreferences = _data.Preferences.GetById(session.PreferencesId);
            this.preferences = userPreferences.MapToPreferences();

            // reload preferences
            MainForm_Load(this, EventArgs.Empty);
        }

        /// <summary>
        /// Sorts sessions by their's time stamp.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimeStampSort_Click(object sender, EventArgs e)
        {
            var sessions = storedSessions.ToList();
            ResetSessionRows();

            if (sessionRowsOrderedByNewest)
            {
                sessionRowsOrderedByNewest = false;
                sessions = sessions.OrderByDescending(s => s.Start).ToList();
                btnTimeStampSort.Text = "\u02C4";
            }
            else
            {
                sessionRowsOrderedByNewest = true;
                sessions = sessions.OrderBy(s => s.Start).ToList();
                btnTimeStampSort.Text = "\u02C5";
            }

            LoadSessionRows(sessions);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ResetSessionRows();

            string filterTarget = txbTarget.Text.Trim();
            var sessions = _data.Sessions
                            .GetAll()
                            .Where(s => s.PingTarget.Contains(filterTarget) || s.Ipv4.Contains(filterTarget));

            LoadSessionRows(sessions);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("This action is irreversible!\n" +
                "Are you sure you want to delete all records?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // purge database
            if (result == DialogResult.Yes)
            {
                _data.PurgeDatabase();

                btnDeleteAll.Enabled = false;

                RefreshSessionRowsUI();
                
                this.console.LogInfo("All records from the database were deleted.", true);
            }

        }

        private void chbAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            btnSaveSession.Enabled = !chbAutoSave.Checked;
        }
    }
}
