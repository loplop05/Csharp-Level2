using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Class_With_Call_back_Event_Example
{
    internal class Program
    {


        public class CustomEventArgs : EventArgs
        {
           public int Parameter1 { get; }
           public string Parameter2 { get; }

            public CustomEventArgs(int param1, string param2)
            {
                this.Parameter1 = param1;
                this.Parameter2 = param2;
            }

        }

        static async Task PerformAsyncOperation(CallbackEventHandler callback)
        {

            await Task.Delay(1000);

            // Create event arguments with two parameters
            CustomEventArgs eventArgs = new CustomEventArgs(42, "Hello from event");

            // Check if the callback event is not null before invoking
            callback?.Invoke(null, eventArgs);
        }



        public delegate void CallbackEventHandler(object sender, CustomEventArgs e);

        public static event CallbackEventHandler CallBackEvent;

        static void OnCallbackReceived(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"Event received: Parameter 1 - {e.Parameter1}, Parameter 2 - {e.Parameter2}");
        }


        static async Task Main(string[] args)
        {


            CallBackEvent += OnCallbackReceived;


            Task PerformTask = PerformAsyncOperation(CallBackEvent);


            Console.WriteLine("Do Some Work ..........");

            await PerformTask;

            Console.WriteLine("Done !");
        }





    }
}
