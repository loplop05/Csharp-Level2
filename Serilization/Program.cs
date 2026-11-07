using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Diagnostics;
namespace Serilization
{

    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class myClass
    {
        [Conditional("DEBUG")]
        public static void DebugMethod()
        {
            Console.WriteLine("Debug Method");
        }
        public static void NonDebugMethod()
        {
            Console.WriteLine("NonDebug Method");
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person
            {
                Name = "Ammar",
                Age = 21
            };

            XmlSerializer serializer = new XmlSerializer(typeof(Person));

            // Serialization 
            using(TextWriter writer = new StreamWriter("person.xml"))
            {
                serializer.Serialize(writer, person);
            }

            //DeSerilization
            using(TextReader reader = new StreamReader("person.xml"))
            {
                Person deSerializedPerson = (Person)serializer.Deserialize(reader);
                Console.WriteLine($"Name : {person.Name} , Age : {person.Age}");

            }


            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Person));


            using (MemoryStream stream = new MemoryStream())
            {
                jsonSerializer.WriteObject(stream, person);

                string jsonString = System.Text.Encoding.UTF8.GetString(stream.ToArray());

                File.WriteAllText("Person.json", jsonString);


            }










            myClass.DebugMethod();
            myClass.NonDebugMethod();


































        }








    }
}
