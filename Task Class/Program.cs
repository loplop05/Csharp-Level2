using System;
using System.Threading.Tasks;


class Program
{


    static async Task<int> PerformAsyncOperation()
    {
        // Simulate an asynchronous operation
        await Task.Delay(2000);

        // Return a result
        return 42;
    }





    static async Task Main()
    {
        // Create and run an asynchronous task
        Task<int> resultTask = PerformAsyncOperation();

        // Do some other work while waiting for the task to complete
        Console.WriteLine("Doing some other work...");

        // Wait for the task to complete and retrieve the result
        int result = await resultTask;


        // Process the result
        Console.WriteLine($"Result: {result}");
    }


  
}