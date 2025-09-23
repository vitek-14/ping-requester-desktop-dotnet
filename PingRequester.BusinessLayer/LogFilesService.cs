using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingRequester.Data.DataObjects;

namespace PingRequester.BusinessLayer
{
    public class LogFilesService
    {
        private string pathToLogFiles;
        private string[] fullFileNames;
        private List<LogFile> logFiles;
        private ServiceState state;

        public LogFilesService(string path)
        {
            this.state = ServiceState.Empty;

            if (!Directory.Exists(path))
            {
                this.state = ServiceState.NotWorking;
                throw new DirectoryNotFoundException($"Specified directory '{path}' does not exists");
            }

            this.pathToLogFiles = path;
            this.state = ServiceState.Active;
        }

        public ServiceState State { get => state; }

        private bool AnyLogFile()
        {
            this.fullFileNames = Directory.GetFiles(this.pathToLogFiles);
            return fullFileNames.Length > 0;
        }

        private void LoadLogFiles()
        {
            foreach (string fullFileName in this.fullFileNames)
            {
                DateTime lastChange = File.GetLastWriteTime(fullFileName);
                LogFile file = new LogFile
                {
                    Path = fullFileName,
                    LastChange = lastChange
                };
                this.logFiles.Add(file);
            }
        }

        private LogFile GetLatestLogFile()
        {
            LogFile latest = logFiles[0];

            foreach (var file in logFiles)
            {
                if (file.LastChange > latest.LastChange)
                    latest = file;
            }

            return latest;
        }

        private LogFile CreateLogFile()
        {
            LogFile file;

            string fileName = $"log_{DateTime.Now.ToString("dd-MM-yyyy_HH-mm")}.log";
            string fullPath = Path.Combine(this.pathToLogFiles, fileName);
            File.WriteAllText(fullPath, "");
            
            file = new LogFile
            {
                Path = fullPath,
                LastChange = DateTime.Now
            };

            return file;
        }

        private void Reset()
        {
            this.logFiles = new List<LogFile>();
            this.fullFileNames = null;
        }

        public void Write(string content)
        {
            Reset();

            LogFile latest;

            if (!AnyLogFile())
            {
                latest = CreateLogFile();
            }
            else
            {
                LoadLogFiles();
                latest = GetLatestLogFile();
                long sizeInBytes = new FileInfo(latest.Path).Length;

                if (sizeInBytes > 524288)   // 0.5 MB
                {
                    latest = CreateLogFile();
                }
                
            }

            // append text to the log file
            // TODO: decide when append and when write
            File.AppendAllText(latest.Path, content);
        }
    }
}
