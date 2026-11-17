using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task_Class_Example_2
{
    internal class Program
    {


        static async Task DownloadAndPrintAsync(string url)
        {
            string content;

            using (WebClient client = new WebClient())
            {
                await Task.Delay(100);

                content = await client.DownloadStringTaskAsync(url);
            }

            Console.WriteLine($" {url} : {content.Length} Charachter Downloaded");
        }



        static async Task Main(string[] args)
        {



            Console.WriteLine("Starting tasks ... ");

            // Start the first task to download and print content length from CNN
            Task task1 = DownloadAndPrintAsync("https://www.cnn.com");
            Console.WriteLine("Task 1 started ... ");

            // Start the second task to download and print content length from Amazon
            Task task2 = DownloadAndPrintAsync("https://www.amazon.com");
            Console.WriteLine("Task 2 started ... ");

            // Start the third task to download and print content length from ProgrammingAdvic
            
            // Wait for all tasks to complete
            await Task.WhenAll(task1, task2);

            // Print a message indicating that all tasks have finished execution
            Console.WriteLine("\nDone, all tasks finished execution. ");
            Console.ReadKey();







        }
    }
}
