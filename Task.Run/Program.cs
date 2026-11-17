using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

public class Program
{

    public static void DownloadFile(string TaskName)
    {
        Console.WriteLine($"{TaskName}: Started!");
        Thread.Sleep(5000); // Simulate long-running operation
        Console.WriteLine($"{TaskName}: Completed!");
    }


    static async Task Main(string[] args)
    {


        Task task1 = Task.Run(() => DownloadFile("Download File 1"));
        Task task2 = Task.Run(() => DownloadFile("Download File 2"));

        await Task.WhenAll(task1, task2);

        Console.WriteLine("Task 1 and Task 2 Completed");








    }
}
