using ObserverPaternOne.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace ObserverPaternOne.Entities
{
    class WeatherData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }
        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(i);
            }
        }

        public void notifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.update(temperature, humidity, pressure);
            }

        }

        public void measurementsChanged()
        {
            notifyObserver();
        }
        public void setMesurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }



     

    }
}
