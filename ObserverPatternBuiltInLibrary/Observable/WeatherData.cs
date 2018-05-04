using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternBuiltInLibrary
{
    public class WeatherData : IObservable<WeatherParameters>
    {
        private List<IObserver<WeatherParameters>> _observers;
        public WeatherData()
        {
            _observers = new List<IObserver<WeatherParameters>>();
        }
        public IDisposable Subscribe(IObserver<WeatherParameters> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new WeatherDataUnSubscriber(_observers, observer);
        }

        public void SendData(WeatherParameters weatherParameters)
        {
            if (_observers != null)
            {
                foreach (var observer in _observers)
                {
                    observer.OnNext(weatherParameters);
                }
            }
        }

        public void EndTransmission()
        {
            if (_observers != null)
            {
                foreach (var observer in _observers.ToArray())
                {
                    observer.OnCompleted();
                }
                _observers.Clear();
            }
        }
    }
}
