using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float pressure;
        private float humidity;
        private float temp;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void SetMeasurements(float pressure, float humidity, float temp)
        {
            this.pressure = pressure;
            this.humidity = humidity;
            this.temp = temp;
            MeasurementsChanged();
        }

        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void NotifyObserver()
        {
            if (observers.Count > 0)
            {
                foreach (IObserver observer in observers)
                {
                    observer.Update(temp, humidity, pressure);
                }
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            if (observers.Contains(o))
            {
                observers.Remove(o);
            }
        }
    }
}
