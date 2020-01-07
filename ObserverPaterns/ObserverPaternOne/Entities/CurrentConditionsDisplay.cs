using System;
using ObserverPaternOne.Interfaces;

namespace ObserverPaternOne.Entities

{
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject weatherData;
        public CurrentConditionsDisplay(ISubject weatherData)
        {
           this.weatherData = weatherData;
            this.weatherData.registerObserver(this);

        }
        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            display();
        }

        public void display()
        {
            Console.WriteLine("\n CurrentConditions Display: \n"
                              + "Temperature: " + temperature + " F degrees;" +
                              "\nHumidity: " + humidity + " % ; " +
                              "\nPressure: " + pressure);
        }

       
    }

}
