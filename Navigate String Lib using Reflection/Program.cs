using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using print = System.Console;
namespace Navigate_String_Lib_using_Reflection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Assembly cont = typeof(string).Assembly;


            Type stringType = cont.GetType("System.String");

            if(stringType != null)
            {
                print.WriteLine("Methods \n\n");

                var stringMethods = stringType.GetMethods(BindingFlags.Public | BindingFlags.Instance)
                           .OrderBy(method => method.Name);
                foreach (var method in stringMethods)
                {
                    Console.WriteLine($"\t{method.ReturnType} {method.Name}({GetParameterList(method.GetParameters())})");
                }




            }






        }
        static string GetParameterList(ParameterInfo[] parameters)
        {
            return string.Join(", ", parameters.Select(parameter => $"{parameter.ParameterType} {parameter.Name}"));
        }
    }
}
