using System;
using System.Threading.Tasks;


class Program
{

    static void DoWork(int i)
    {
        Console.WriteLine($"Executing iteration {i} on thread {Task.CurrentId}");

        Task.Delay(2000).Wait();
    }




    static void Main()
    {
        // Define the number of iterations
        int numberOfIterations = 10;


        // Use Parallel.For to execute the loop in parallel
        Parallel.For(0, numberOfIterations, DoWork);

        Console.WriteLine("All iterations completed.");
    }
}
