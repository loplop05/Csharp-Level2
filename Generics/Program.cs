using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {


       public static T GetFirst<T>(T[]arr)
        {
            return arr[0];
        }


        public class GenericClass<T>
        {
            private T content; 


            public GenericClass(T value)
            {
                content = value;
            }

            public T GetContent()

            {
                return content;
            }




        }



        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30 };
            string[] names = { "Ammar", "Ahmad", "Ali" };
          //  Console.WriteLine(GetFirst<int>(numbers));

            GenericClass<int> intBox = new GenericClass<int>(42);
            Console.WriteLine("Content of intBox: " + intBox.GetContent());

            GenericClass<string> stringBox = new GenericClass<string>("Ammar");

            Console.WriteLine("Content of stringBox: " + stringBox.GetContent());


        }
    }
}
