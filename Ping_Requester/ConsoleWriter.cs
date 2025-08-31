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

        public Color InfoTextColor { get => Color.White; }
        public Color WarningTextColor { get => Color.Orange; }
        public Color MessageTextColor { get => Color.FromArgb(78, 215, 241); }
        public Color ErrorTextColor { get => Color.Red; }

        public ConsoleWriter(RichTextBox console)
        {
            this.console = console;
        }

        private void Log(string message)
        {
            this.console.AppendText($"{message}\n");
        }

        public void LogInfo(string message)
        {
            this.console.SelectionColor = InfoTextColor;
            this.console.AppendText("[INFO]: ");
            Log(message);
        }

        public void LogError(string message)
        {
            this.console.SelectionColor = ErrorTextColor;
            this.console.AppendText("[ERROR]: ");
            this.console.SelectionColor = InfoTextColor;
            Log(message);
        }

        public void LogWarning(string message)
        {
            this.console.SelectionColor = WarningTextColor;
            this.console.AppendText("[WARNING]: ");
            this.console.SelectionColor = InfoTextColor;
            Log(message);
        }

        public void LogMessage(string message)
        {
            this.console.SelectionColor = MessageTextColor;
            this.console.AppendText("[MESSAGE]: ");
            this.console.SelectionColor = InfoTextColor;
            Log(message);
        }
    }
}
