using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternBuiltInLibrary
{
    public class CurrentConditionsDisplay : IObserver<WeatherParameters>
    {
        private string _name;
        private IDisposable _unsubscriber;

        public CurrentConditionsDisplay(string name)
        {
            _name = name;
        }

        public void Subscribe(IObservable<WeatherParameters> provider)
        {
            if (provider != null)
            {
                _unsubscriber = provider.Subscribe(this);
            }            
        }

        public void UnSubscribe()
        {
            _unsubscriber.Dispose();
        }

        public void OnCompleted()
        {
            Console.WriteLine("Transmission completed from server side to this instance - {0}", _name);
            UnSubscribe();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(WeatherParameters value)
        {
            Console.WriteLine("Weather Parameters are: Pressure {0}, Humidity {1}, Temperature {2} - Device Name {3}", value.Pressure, value.Humidity, value.Temperature, this._name);
        }
    }
}
