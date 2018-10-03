using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_Temperature
{


    public class Temperature
    {
        public enum TemperatureScale
        {
            Celsius,
            Fahrenheit
        }
        public double Fahrenheit {
            get { return temperature * 9 / 5 + 32; }
            set { temperature = (value - 32) * 5 / 9; }
        }
        public double Celsius
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public void SetTemperature(double v, TemperatureScale u)
        {
            switch (u)
            {
                case TemperatureScale.Fahrenheit:
                    Fahrenheit = v;
                    break;
                default:
                    Celsius = v;
                    break;
            }
        }
        private double temperature;
    }
}