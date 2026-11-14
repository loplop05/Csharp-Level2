using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Event_Log
{
    public class Program
    {
        static void Main(string[] args)
        {


            string sourceName = "AmmarApp";


            // Create the event source if it does not exist
            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
                Console.WriteLine("Event source created.");
            }


            // Log an information event
            EventLog.WriteEntry(sourceName, "This is an information event.", EventLogEntryType.Information);


            Console.WriteLine("Event written to the log.");

            EventLog.WriteEntry(sourceName, "This My Warning :- )", EventLogEntryType.Warning);

            // Log an Error event
            EventLog.WriteEntry(sourceName, "This My Error :- )", EventLogEntryType.Error);



        }
    }
}
