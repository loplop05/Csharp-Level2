using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using print = System.Console;

using static System.Math; 


namespace FuncDelegate
{


   



    public class Program
    {

        static Func<int, int> square = SquareNumber;
        static Func<int, int> square2 = x => x * x; 

        static int SquareNumber(int x )
        {
            return x * x; 
        }


        static Func<string, string, int> cast = CastNumbersToSum;

        static int CastNumbersToSum(string x , string y)
        {
            return Convert.ToInt32(x) + Convert.ToInt32(y);
        }


        Action parameterlessAction = ParameterLessMethod;
        Action parameterlessAction2 = () =>
        {
            Console.WriteLine("This is param less action");
        };

        Action<int> actionWithIntParam = (x) =>
        {
            Console.WriteLine($"This is Action with param {x}");
        };


        Action<string,int> actionWith2param = (str,num) =>
        {
            Console.WriteLine($"This is Action with param {str} and {num}");
        };


        static void ParameterLessMethod()
        {
            Console.WriteLine("Param less method");
        }


        static Predicate<int> isEvenPredicate = isEven;

        static bool isEven(int x )
        {
            return x % 2 == 0;
        }


         delegate int Operation(int x, int y);
        static void ExecuateOperation(int x ,int y , Operation ops)
        {
            int res = ops(x, y);
            Console.WriteLine(res);
        }

        static int Add (int x , int y)
        {
            return x + y;
        }

        static int Sub(int x , int y)
        {
            return x - y;
        }


        static void Procedure1(int?age)
        {
            if (!age.HasValue) { print.Write("Age is null"); }
            else { print.Write($"Age is {age}"); }


        }





        static void Main(string[] args)
        {

            

            Nullable<int> nullableInt = null;

            int? nullable = null;


            int result = nullableInt ?? 0;

            print.WriteLine("String Representaion ->" + (result.ToString() ?? "null"));
            Procedure1(null);
        }







    }
}
