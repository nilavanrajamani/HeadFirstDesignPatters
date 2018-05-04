using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WeatherStation
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(40, 20, 20.4f);
            Console.ReadLine();
        }
    }
}
