using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingRequester.Data.DataObjects;

namespace PingRequester.BusinessLayer
{
    /// <summary>
    /// LogFileService class handles logging console output to the log files.
    /// </summary>
    public class LogFilesService
    {
        private string pathToLogFiles;
        private string[] fullFileNames;
        private List<LogFile> logFiles;

        /// <summary>
        /// Default constructor of the class.
        /// </summary>
        /// <param name="path"></param>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public LogFilesService(string path)
        {
            if (!Directory.Exists(path))
            {
                throw new DirectoryNotFoundException($"Specified directory '{path}' does not exists");
            }

            this.pathToLogFiles = path;
        }
        
        /// <summary>
        /// Checks if any log file exists in the target folder path.
        /// </summary>
        /// <returns>Bool depending on the result.</returns>
        private bool AnyLogFile()
        {
            this.fullFileNames = Directory.GetFiles(this.pathToLogFiles);
            return fullFileNames.Length > 0;
        }

        /// <summary>
        /// Loads data into the List<LogFile>.
        /// </summary>
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

        /// <summary>
        /// Finds LogFile with the latest date of change.
        /// </summary>
        /// <returns>LogFile instance</returns>
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

        /// <summary>
        /// Creates new .log file.
        /// </summary>
        /// <returns>Returns the instance of the created log file.</returns>
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

        /// <summary>
        /// Resets List<LogFile> and fullFileName.
        /// </summary>
        private void Reset()
        {
            this.logFiles = new List<LogFile>();
            this.fullFileNames = null;
        }

        /// <summary>
        /// Appends content to the log file. If no log file exists in the target directory, it creates a new one. If log file exceeds
        /// its size limit, it will create another log file and it will use this one instead.
        /// </summary>
        /// <param name="content"></param>
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
            File.AppendAllText(latest.Path, content);
        }
    }
}
