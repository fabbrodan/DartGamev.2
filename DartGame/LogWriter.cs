using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartGame
{
    public static class LogWriter
    {
        private static string LogPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DartLog.txt";

        public static void Write(string Line)
        {
            using (StreamWriter writer = File.AppendText(LogPath))
            {
                DateTime now = DateTime.Now;
                writer.WriteLine(now.ToString() + " " + Line);
            }
        }

        public static void NewFile()
        {
            if (File.Exists(LogPath))
            {
                File.Delete(LogPath);
            }
        }
    }
}
