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
        private string template;

        /// <summary>
        /// Default constructor of the class.
        /// </summary>
        /// <param name="path"></param>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public LogFilesService(string path, string timeStampTemplate)
        {
            if (!Directory.Exists(path))
            {
                throw new DirectoryNotFoundException($"Specified directory '{path}' does not exists");
            }

            this.pathToLogFiles = path;
            this.template = timeStampTemplate;
        }
        
        /// <summary>
        /// Checks if any log file exists in the target folder path.
        /// </summary>
        /// <returns>Bool depending on the result.</returns>
        private void LoadFullFileNames()
        {
            this.fullFileNames = Directory.GetFiles(this.pathToLogFiles)
                .Where(f => Path.GetFileName(f).StartsWith("log_") && f.EndsWith(".log")).ToArray();
        }

        /// <summary>
        /// Loads data into the List<LogFile>.
        /// </summary>
        private void LoadLogFiles()
        {
            foreach (string fullFileName in this.fullFileNames)
            {
                var timeStamp = fullFileName.ToDateTime(this.template);
                LogFile file = new LogFile
                {
                    Path = fullFileName,
                    TimeStamp = timeStamp
                };
                this.logFiles.Add(file);
            }
        }

        /// <summary>
        /// Creates new .log file.
        /// </summary>
        /// <returns>Returns the instance of the created log file.</returns>
        private LogFile CreateLogFile()
        {
            LogFile file;

            var timeStamp = DateTime.Now;
            string fileName = $"log_{timeStamp.ToTimeStampFormat(this.template)}.log";
            string fullPath = Path.Combine(this.pathToLogFiles, fileName);
            File.WriteAllText(fullPath, "");    // creates empty log file
            
            file = new LogFile
            {
                Path = fullPath,
                TimeStamp = timeStamp
            };

            return file;
        }

        private static bool HasTodaysDate(LogFile logFile)
        {
            return Equals(DateTime.Today.Date, logFile.TimeStamp.Date);
        }

        private LogFile GetTodaysLogFile()
        {
            LogFile todaysLogFile = null;

            foreach (var logFile in this.logFiles)
            {
                if (HasTodaysDate(logFile))
                {
                    todaysLogFile = logFile;
                }
            }

            return todaysLogFile;
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

            LogFile workingLogFile;

            LoadFullFileNames();

            if (fullFileNames.Length == 0)
            {
                workingLogFile = CreateLogFile();
            }
            else
            {
                LoadLogFiles();
                workingLogFile = GetTodaysLogFile();

                if (workingLogFile == null)
                {
                    workingLogFile = CreateLogFile();
                }
            }

            // append text to the log file
            File.AppendAllText(workingLogFile.Path, content);
        }
    }
}
