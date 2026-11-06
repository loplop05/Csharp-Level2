using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExample
{

    public class Logger
    {
        public delegate void LogAction(string Message);

        private LogAction _logAction; 


        public Logger(LogAction action)
        {
            _logAction = action;
        }

        public void Log(string message)
        {
            _logAction(message);
        }

    }




    public class Program
    {


        public static void LogToFile(string message)
        {
            string fileName = "log.txt";
            using(StreamWriter writer = new StreamWriter(fileName,true))
            {
                writer.WriteLine(message);
            }
        }

        public static void LogToScreen(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {

            Logger screenLogger = new Logger(LogToScreen);
            Logger fileLogger = new Logger(LogToFile);


            screenLogger.Log("This message will be showing on the Screen");
            fileLogger.Log("This message will be showing on the File Logger");



        }
    }
}
