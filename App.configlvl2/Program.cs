using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


internal class Program
{
    static void Main(string[] args)
    {

        string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        string logLevel = ConfigurationManager.AppSettings["LogLevel"];
        string koko = ConfigurationManager.AppSettings["koko"];
        string myDbConnection = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        Console.WriteLine("\nConnectionString = " + connectionString);
        Console.WriteLine("\nlogLevel = " + logLevel);
        Console.WriteLine("\nkoko = " + koko);

        Console.WriteLine("\nMyDbConnection = " + myDbConnection);
        Console.ReadKey();



    }
}
