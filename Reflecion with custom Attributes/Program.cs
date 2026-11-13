using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflecion_with_custom_Attributes
{
    public class Program
    {
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method ,AllowMultiple =true)]
        public class MyCustomAttribute : Attribute
        {
            public string Description;

            public MyCustomAttribute(string description)
            {
                this.Description = description;
            }


        }


        [MyCustom("This is class Attribute")]
        class MyClass
        {
            [MyCustom("This is method Attribute")]
            public void method1()
            {

            }





        }

        static void Main(string[] args)
        {
            Type type = typeof(MyClass);


            // Get class-level attributes
            object[] classAttributes = type.GetCustomAttributes(typeof(MyCustomAttribute), false);
            foreach (MyCustomAttribute attribute in classAttributes)
            {
                Console.WriteLine($"Class Attribute: {attribute.Description}");
            }

            // Get method-level attributes
            MethodInfo methodInfo = type.GetMethod("method1");
            object[] methodAttributes = methodInfo.GetCustomAttributes(typeof(MyCustomAttribute), false);
            foreach (MyCustomAttribute attribute in methodAttributes)
            {
                Console.WriteLine($"Method Attribute: {attribute.Description}");
            }

        }
    }
}
