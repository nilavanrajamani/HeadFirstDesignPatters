using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternBuiltInLibrary
{
    public class WeatherDataUnSubscriber : IDisposable
    {
        private IList<IObserver<WeatherParameters>> _observers;
        private IObserver<WeatherParameters> _observer;

        public WeatherDataUnSubscriber(IList<IObserver<WeatherParameters>> observers, IObserver<WeatherParameters> observer)
        {
            _observers = observers;
            _observer = observer;
        }
        public void Dispose()
        {
            if(_observers!=null && _observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
