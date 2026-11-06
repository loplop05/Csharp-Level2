using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate
{


   



    public class Program
    {

        static Func<int, int> square = SquareNumber; 

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

       static void ParameterLessMethod()
        {
            Console.WriteLine("Param less method");
        }


        static Predicate<int> isEvenPredicate = isEven;

        static bool isEven(int x )
        {
            return x % 2 == 0;
        }





        static void Main(string[] args)
        {

            int result = square(4);
            Console.Write(result);

            



        }
    }
}
