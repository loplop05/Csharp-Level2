using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Practice
{
    public class Program
    {


        static void DisplayProperties(object obj)
        {
            Type type = obj.GetType();

            foreach (PropertyInfo property in type.GetProperties())
            {
                object value = property.GetValue(obj);

                Console.WriteLine($"{property.Name}: {value}");
            }
        }
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double GPA { get; set; }

            public void Introduce()
            {
                Console.WriteLine($"My name is {Name}");
            }

            public void Study()
            {
                Console.WriteLine("Student is studying...");
            }
        }

        public class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Position { get; set; }
            public bool CreditLoan { get; set; }

            public void Introduce()
            {
                Console.WriteLine($"My name is {Name}");
            }

            public void Study()
            {
                Console.WriteLine("Employee is working...");
            }
        }



        static void Main(string[] args)
        {

            Student student = new Student
            {
                Name = "Ammar",
                Age = 22,
                GPA = 3.5
            };

            Employee emp = new Employee
            {
                Name = "Malek",
                Age = 22,
                CreditLoan = true,
                Position = "Sr Eng"
            };

            DisplayProperties(emp );










        }
    }
}
