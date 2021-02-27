using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourlyPromptWF
{
    class LogUtils
    {
        static readonly string LogDirectory = @"c:\hourly_log\";

        public static void WriteToLog(string text, string time)
        {
            using (StreamWriter sw = File.AppendText(GetLogFile()))
            {
                sw.WriteLine("#######START######");
                sw.WriteLine($"Entry for [{time}]");
                sw.WriteLine("##################");
                sw.WriteLine(text);
                sw.WriteLine("########END#######\n"); ;
            }
        }

        public static string GetLogFile()
        {
            string fileName = LogDirectory + DateTime.Now.ToString("yyyy_MM_dd") + ".txt";

            if (!File.Exists(fileName))
            {
                if (!Directory.Exists(LogDirectory))
                {
                    Directory.CreateDirectory(LogDirectory);
                }

                File.Create(fileName);
            }

            return fileName;
        }
    }
}
