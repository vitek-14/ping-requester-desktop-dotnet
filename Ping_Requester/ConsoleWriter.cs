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
        public Color SuccessTextColor { get => Color.Green; }
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
            this.console.AppendText("[TEXT]: ");
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

        public void LogSuccess(string message)
        {
            this.console.SelectionColor = SuccessTextColor;
            this.console.AppendText("[SUCCESS]: ");
            this.console.SelectionColor = InfoTextColor;
            Log(message);
        }
    }
}
