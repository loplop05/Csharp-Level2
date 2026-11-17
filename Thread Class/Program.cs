using System;
using System.Threading;

class Program
{


    static void Method1()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(" Method  1: " + i);
            Thread.Sleep(1000);
        }
    }

    static void Method2()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(" Method  2: " + i);
            Thread.Sleep(1000);
        }
    }

    static void ParamMethod(string ThreadName)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{ThreadName} ParamMethod: " + i);
            Thread.Sleep(1000);
        }
    }


    static void Main()
    {
        // Note that your program is the main thread.


        // Create a new thread and start it
        Thread t1 = new Thread(Method1);
        t1.Start();
        Thread t2 = new Thread(Method2);
        t2.Start();

        t1.Join();
        t2.Join();

        Thread paramThread = new Thread(() => ParamMethod("ParamThread"));
        paramThread.Start();







        // Main thread continues its execution
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Main Thread: " + i);
            Thread.Sleep(1000); // Sleep for 1 second
        }
        Console.ReadKey();
    }



}
