using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileEncodingTool
{
    public class LogConsole
    {
        static string logFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "err.txt");
        public static async Task LogAsync(string msg)
        {
            byte[] data = Encoding.UTF8.GetBytes(msg);
            
            FileStream fs = new FileStream(logFileName, FileMode.OpenOrCreate);
            fs.Position = fs.Length;
            StreamWriter sw = new StreamWriter(fs,Encoding.UTF8);
            await sw.WriteLineAsync(string.Format("{0}-{1}", DateTime.Now.ToString("YYYY-MM-dd HH:mm:ss"), msg));
            await sw.FlushAsync();
            sw.Close();            
            fs.Close();
        }
        public static void Log(string msg)
        {
            byte[] data = Encoding.UTF8.GetBytes(msg);

            FileStream fs = new FileStream(logFileName, FileMode.OpenOrCreate);
            fs.Position = fs.Length;
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(string.Format("{0}-{1}", DateTime.Now.ToString("YYYY-MM-dd HH:mm:ss"), msg));
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
