
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempChangeEvent
{
    

    public class TemperatureChangedEventArgs : EventArgs
    {
        public double OldTemperature { get; }
        public double NewTemperature { get; }
        public double Differnce { get; }
        public TemperatureChangedEventArgs(double oldTemperature, double newTemperature)
        {
            this.OldTemperature = oldTemperature;
            this.NewTemperature = newTemperature;
            this.Differnce = newTemperature - oldTemperature;
        }



    }


    public class Thermostat
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        private double OldTemperature;
        private double CurrentTemperature;

        public void SetTemperature(double newTemperature)
        {
            if (newTemperature != CurrentTemperature)
            {
                OldTemperature = CurrentTemperature;
                CurrentTemperature = newTemperature;
                OnTemperatureChanged(OldTemperature, newTemperature);
            }
        }

        private void OnTemperatureChanged(double oldTemperature, double newTemperature)
        {

            OnTemperatureChanged(new TemperatureChangedEventArgs(oldTemperature, newTemperature));


        }


        private void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }


    }


    public class Display
    {

        public void Subscribe(Thermostat thermostat)
        {
            thermostat.TemperatureChanged += HandleTemretuareChagne;
        }


        public void HandleTemretuareChagne(object sender , TemperatureChangedEventArgs e)
        {

            Console.WriteLine("\n\n Temperature Changed \n ");
            Console.WriteLine($" Temperature Changed From -> {e.OldTemperature} ");
            Console.WriteLine($" Temperature Changed To  -> {e.NewTemperature}");
            Console.WriteLine($" Temperature Diff  -> {e.Differnce}");



        }




    }

    public class Program
    {
        static void Main(string[] args)
        {

            Thermostat thermostat = new Thermostat();

            Display display = new Display();
            display.Subscribe(thermostat);

            thermostat.SetTemperature(50);
            thermostat.SetTemperature(100);
            thermostat.SetTemperature(250);









        }
    }




























}
