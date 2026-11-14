using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Windows_Registry
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\YourSoftware";
            string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\YourSoftware";
            string valueName = "YourValueName";
            string valueData = "YourValueData";


            try
            {
                Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);
                Console.WriteLine($"Value {valueName} succecfully written to the Registery");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"An Error occured -> {ex.Message}");

            }



            // Specify the Registry key and path
            // string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\YourSoftware";
            string keyPath2 = @"HKEY_CURRENT_USER\SOFTWARE\YourSoftware";
            string valueName2 = "YourValueName";

            try
            {
                string value = Registry.GetValue(keyPath2, valueName2, null) as string;
           
            if (value != null)
            {
                Console.WriteLine($"The value of {valueName2} is: {value}");
            }



            else

                Console.WriteLine($"Value {valueName2} not found in the Registry.");


        }catch(Exception ex)
            {
                Console.WriteLine($"Error :-> {ex.Message}") ;
            }








        }
    }
}
