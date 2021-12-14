using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace MIIPL.Common
{
    public class FileLogger : iLogger
    {
        private static object objLock = new object();
        private StreamWriter output; // Log file
        private string LogFileNamePattern;
        private string LogFilePath;
        private string strTransLogFileName;
        private string FilePrefix = "TransLog";
        private string Extenstion = ".txt";
        public FileLogger()
            : this(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"\Log", "yyyyMMdd")
        {
        }
        public FileLogger(string logFilePath, string logFileNamePattern)
            : this(logFilePath, logFileNamePattern, "TransLog", ".txt")
        {
        }
        public FileLogger(string logFilePath, string logFileNamePattern, string filePrefix, string extenstion)
        {
            LogFilePath = logFilePath;
            LogFileNamePattern = logFileNamePattern;
            FilePrefix = filePrefix;
            Extenstion = extenstion;
            // Create log file
            //output = new StreamWriter(filename, true);
        }       
        public void CreateTransLogFile()
        {
            string strTransLogFilePath = LogFilePath;//strTransLogFilePath = "E:\\Projects\\ATHMA\\ATHMA_Adapter\\TransactionLog";
            strTransLogFileName = strTransLogFilePath + "\\" + FilePrefix +DateTime.Now.ToString(LogFileNamePattern) + Extenstion;
           // strTransLogFileName = strTransLogFilePath + "\\" + FilePrefix + DateTime.Now.ToString(LogFileNamePattern);
            if (!System.IO.File.Exists(strTransLogFileName))
            {
                Directory.CreateDirectory(strTransLogFilePath);
                output = File.CreateText(strTransLogFileName);//(strTransLogFilePath + "\\TransLog.txt");
                output.Close();
            }
        }
        public void WriteEntry(object sender, string msg)
        {
            lock (objLock)
            {
                CreateTransLogFile();
                File.AppendAllText(strTransLogFileName, Convert.ToString(DateTime.Now) + " : ");
                File.AppendAllText(strTransLogFileName, msg + Environment.NewLine);
                //output.Flush();
            }
            if (this.OnWriteEntry != null)
            {
                this.OnWriteEntry(sender, new LoggerEventArgs(msg));
            }
        }
        public event WriteEntryDelegate OnWriteEntry;
        //public event WriteErrorDelegate OnWriteError;
        #region iLogger Members


        public void WriteError(object sender, string message)
        {
            //string m_methodName = "";
            //string m_className = "";
            //string m_fileName = "";
            //string m_lineNumber = "";
            ////var st = new StackTrace(); 
            //return LogManager.GetLogger(stackTrace.GetFrame(1).GetMethod().DeclaringType); 

            // now frameIndex is the first 'user' caller frame
            //StackFrame aFrame = st.GetFrame(0);
            StackFrame Callstack = new StackFrame(1, true);
            //if (Callstack != null)
            //{
            //    System.Reflection.MethodBase method = Callstack.GetMethod();
            //    if (method != null)
            //    {
            //        m_methodName = method.Name;
            //        if (method.DeclaringType != null)
            //        {
            //            m_className = method.DeclaringType.FullName;
            //        }
            //    }
            //    m_fileName = Callstack.GetFileName();
            //    m_lineNumber = Callstack.GetFileLineNumber().ToString(System.Globalization.NumberFormatInfo.InvariantInfo);
            //}

            string logMessage = string.Format("{0} {1}:{2} {3} \t{4}", DateTime.Now.ToString(), Callstack.GetFileName(), Callstack.GetFileLineNumber(), Callstack.GetMethod(), message);
            WriteEntry(sender, logMessage);
        }

        #endregion
    }
}
