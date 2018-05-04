using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternBuiltInLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay("Weather instrument 1");
            currentConditionsDisplay.Subscribe(weatherData);
            CurrentConditionsDisplay currentConditionsDisplay2 = new CurrentConditionsDisplay("Weather instrument 2");
            currentConditionsDisplay2.Subscribe(weatherData);

            weatherData.SendData(new WeatherParameters() { Humidity = 95, Pressure = 95, Temperature = 32 });
            currentConditionsDisplay.UnSubscribe();
            weatherData.SendData(new WeatherParameters() { Humidity = 12, Pressure = 20, Temperature = 50 });
            weatherData.EndTransmission();
            Console.ReadLine();
        }
    }
}
