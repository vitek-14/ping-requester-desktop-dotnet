using PingRequester.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingRequester.Client
{
    public class ConsoleWriter : IConsoleService
    {
        private RichTextBox console;
        private Label lblInfo;

        public Color InfoTextColor { get => Color.White; }
        public Color WarningTextColor { get => Color.Orange; }
        public Color MessageTextColor { get => Color.FromArgb(78, 215, 241); }
        public Color ErrorTextColor { get => Color.Red; }

        public ConsoleWriter(RichTextBox console, Label info)
        {
            this.console = console;
            this.lblInfo = info;
        }

        private void Log(string message, bool logInfoLabel)
        {
            this.console.AppendText($"{message}\n");
            this.console.ScrollToCaret();

            if (logInfoLabel)
                lblInfo.Text = $"Info: {message}";
        }

        public void LogInfo(string message, bool logInfoLabel = false)
        {
            this.console.SelectionColor = InfoTextColor;
            this.console.AppendText("[INFO]: ");
            Log(message, logInfoLabel);
        }

        public void LogError(string message, bool logInfoLabel = false)
        {
            this.console.SelectionColor = ErrorTextColor;
            this.console.AppendText("[ERROR]: ");
            this.console.SelectionColor = InfoTextColor;
            Log(message, logInfoLabel);
        }

        public void LogWarning(string message, bool logInfoLabel = false)
        {
            this.console.SelectionColor = WarningTextColor;
            this.console.AppendText("[WARNING]: ");
            this.console.SelectionColor = InfoTextColor;
            Log(message, logInfoLabel);
        }

        public void LogMessage(string message, bool logInfoLabel = false)
        {
            this.console.SelectionColor = MessageTextColor;
            this.console.AppendText("[MESSAGE]: ");
            this.console.SelectionColor = InfoTextColor;
            Log(message, logInfoLabel);
        }
    }
}
