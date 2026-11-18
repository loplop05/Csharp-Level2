using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Invoke
{
    internal class Program
    {
        static void DownloadData()
        {
            Console.WriteLine("Downloading Data...");
        }

        static void ProcessData()
        {
            Console.WriteLine("Processing Data...");
        }

        static void GenerateReport()
        {
            Console.WriteLine("Generating Report...");
        }


        static void Main(string[] args)
        {
            Parallel.Invoke(DownloadData, ProcessData, GenerateReport);



        }








    }
}
