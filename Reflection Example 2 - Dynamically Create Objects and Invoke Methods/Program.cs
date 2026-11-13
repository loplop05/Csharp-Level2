using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using print = System.Console;
using System.Reflection;

namespace Reflection_Example_2___Dynamically_Create_Objects_and_Invoke_Methods
{


    public class myClass
    {
        public int probirety1 { get; set; };


        public void Method1()
        {
            print.WriteLine("Method 1 is Excectued\n");
        }

        public void Method2(int val1,int val2)
        {
            print.WriteLine($"Method 2 is Excectued with parameters {val1}  {val2}\n");
        }

    }

   




    public class Program
    {


        static string GetParameterList(ParameterInfo[] parameters)
        {
            return string.Join(", ", parameters.Select(parameter => $"{parameter.ParameterType} {parameter.Name}"));
        }


        static void Main(string[] args)
        {
            Type myclassType = typeof(myClass);

            print.WriteLine($"Type Name: {myclassType.Name} ");
            print.WriteLine($"Full Name: {myclassType.FullName} ");


            print.WriteLine("Properities : \n\n");

            print.WriteLine("\nProperties:");
            foreach (var property in myclassType.GetProperties())
            {
                print.WriteLine($"Property Name: {property.Name}, Type: {property.PropertyType} ");

            }

            foreach (var methods in myclassType.GetMethods())
            {
                print.WriteLine($" {methods.ReturnType}   {methods.Name}   ({GetParameterList(methods.GetParameters())}");

            }

            object myClassInstance = Activator.CreateInstance(myclassType);

            // Set the value of Property1 using reflection
            myclassType.GetProperty("Property1").SetValue(myClassInstance, 42);
            Console.WriteLine("\nSet Property1 to 42 using reflection:");


        }
















    }
}
