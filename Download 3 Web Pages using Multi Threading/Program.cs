using System;
using System.Net;
using System.Threading;

class Program
{

    static void DownloadAndPrint(string url)
    {
        try
        {
            using (WebClient client = new WebClient())
            {
                Thread.Sleep(1000);

                string content = client.DownloadString(url);

                Console.WriteLine($"{url}: {content.Length} characters downloaded");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{url}: Error - {ex.Message}");
        }
    }

    static void Main()
    {

        Console.WriteLine("Starting threads...");

        Thread t1 = new Thread(() => DownloadAndPrint("https://www.cnn.com"));
        t1.Start();
        Console.WriteLine("Thread 1 started...");

        Thread t2 = new Thread(() => DownloadAndPrint("https://www.amazon.com"));
        t2.Start();
        Console.WriteLine("Thread 2 started...");

        Thread t3 = new Thread(() => DownloadAndPrint("https://www.github.com"));
        t3.Start();
        Console.WriteLine("Thread 3 started...\n");


        t1.Join();
        t2.Join();
        t3.Join();


        Console.WriteLine("\nDone all threads finished execution.");
        Console.ReadKey();

    }
}
