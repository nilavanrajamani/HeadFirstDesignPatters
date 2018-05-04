using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temp;
        private float humidity;
        private float pressure;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + temp + "F degrees and " + humidity + "% humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }
    }
}
