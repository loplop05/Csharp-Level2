using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace custom_attributes_for_validation
{
    public class Program
    {
        [AttributeUsage(AttributeTargets.Property,AllowMultiple =true)]
        public class RangeAttribute : Attribute
        {
            public int Min { get;  }
            public int Max { get;  }
            
            public string ErrorMessage { get; set; }
        

            public RangeAttribute(int min , int max)
            {
                this.Min = min;
                this.Max = max;
            }

        }

        
        public class Person
        {
            [Range(18,99,ErrorMessage ="Age must be between 18 and 99")]
            public int Age { get; set; }
            public string Name { get; set; }
                    
        
        
        }



        static bool ValidatePerson(Person Person)
        {
            Type type = typeof(Person);

            foreach(var property in type.GetProperties())
            {

                if(Attribute.IsDefined(property,typeof(RangeAttribute)))
                {
                    var rangeAttribute = (RangeAttribute)Attribute.GetCustomAttribute(property, typeof(RangeAttribute));

                    int value = (int)property.GetValue(Person);

                    if (value < rangeAttribute.Min || value > rangeAttribute.Max)
                    {

                        Console.WriteLine($"Validation failed for proberty {property.Name} : {rangeAttribute.ErrorMessage}");

                        return false; 
                    }

                }


               



            }
            return true;

        }







        static void Main(string[] args)
        {
            Person person = new Person { Age = 225, Name = "Ammar alharoun" };

            if(ValidatePerson(person))
            {
                Console.WriteLine("Validated Person (:");
            }else
            {
                Console.WriteLine("NOT VALIDATED Person ):");
            }



        }





    }
}
