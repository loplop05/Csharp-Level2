using System;
using System.Diagnostics;
using System.Text;

namespace string_builder
{
    public class Program
    {
        public void ConcatnateString(int iter)
        {
            string result = "";

            for (int i = 0; i < iter; i++)
            {
                result += "A";
            }
        }

        public void ConcatnateStringBuilder(int iter)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < iter; i++)
            {
                sb.Append("A");
            }

            string result = sb.ToString();
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int iterations = 1000000;

            Stopwatch sw = new Stopwatch();

            // Test String Concatenation
            sw.Start();
            program.ConcatnateString(iterations);
            sw.Stop();

            Console.WriteLine("String Concatenation:");
            Console.WriteLine($"Elapsed Time: {sw.ElapsedMilliseconds} ms");

            sw.Reset();

            // Test StringBuilder
            sw.Start();
            program.ConcatnateStringBuilder(iterations);
            sw.Stop();

            Console.WriteLine("\nStringBuilder:");
            Console.WriteLine($"Elapsed Time: {sw.ElapsedMilliseconds} ms");
        }
    }
}