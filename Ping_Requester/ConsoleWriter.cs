using PingRequester.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingRequester.Client
{
    /// <summary>
    /// ConsoleWriter class handles console output and styling.
    /// </summary>
    public class ConsoleWriter : IConsoleService
    {
        private RichTextBox console;
        private Label lblInfo;

        public Color InfoTextColor { get => Color.White; }
        public Color WarningTextColor { get => Color.Orange; }
        public Color MessageTextColor { get => Color.FromArgb(78, 215, 241); }
        public Color ErrorTextColor { get => Color.Red; }

        /// <summary>
        /// Default constructor of the ConsoleWriter class.
        /// </summary>
        /// <param name="console"></param>
        /// <param name="info"></param>
        public ConsoleWriter(RichTextBox console, Label info)
        {
            this.console = console;
            this.lblInfo = info;
        }

        /// <summary>
        /// Logs the message into the console.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="logInfoLabel"></param>
        private void Log(string message, bool logInfoLabel)
        {
            this.console.AppendText($"{message}\n");
            this.console.ScrollToCaret();

            if (logInfoLabel)
                lblInfo.Text = $"Info: {message}";
        }

        /// <summary>
        /// Logs informative message into the console.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="logInfoLabel"></param>
        public void LogInfo(string message, bool logInfoLabel = false)
        {
            this.console.SelectionColor = InfoTextColor;
            this.console.AppendText("[INFO]: ");
            Log(message, logInfoLabel);
        }

        /// <summary>
        /// Logs error message into the console.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="logInfoLabel"></param>
        public void LogError(string message, bool logInfoLabel = false)
        {
            this.console.SelectionColor = ErrorTextColor;
            this.console.AppendText("[ERROR]: ");
            this.console.SelectionColor = InfoTextColor;
            Log(message, logInfoLabel);
        }

        /// <summary>
        /// Logs warning message into the console.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="logInfoLabel"></param>
        public void LogWarning(string message, bool logInfoLabel = false)
        {
            this.console.SelectionColor = WarningTextColor;
            this.console.AppendText("[WARNING]: ");
            this.console.SelectionColor = InfoTextColor;
            Log(message, logInfoLabel);
        }

        /// <summary>
        /// Logs message of type Message into the console (for example available updates, internet connection, etc)
        /// </summary>
        /// <param name="message"></param>
        /// <param name="logInfoLabel"></param>
        public void LogMessage(string message, bool logInfoLabel = false)
        {
            this.console.SelectionColor = MessageTextColor;
            this.console.AppendText("[MESSAGE]: ");
            this.console.SelectionColor = InfoTextColor;
            Log(message, logInfoLabel);
        }
    }
}
