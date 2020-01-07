using System;
using ObserverPaternOne.Interfaces;

namespace ObserverPaternOne.Entities 
{
    class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject _weatherData;
        private float maxTemp = 0;
        private float minTemp = 10000;
        private float avTemp;
        private float numRead = 0;

        public StatisticsDisplay(ISubject weatherData)
        {
            this._weatherData = weatherData;
            this._weatherData.registerObserver(this);
        }
        public void update(float temperature, float humidity, float presure)
        {

            avTemp += temperature;
            numRead++;

            this.temperature = temperature;
            if (temperature > maxTemp)
            {
                maxTemp = temperature;
            }
            if(temperature < minTemp)
            {
                minTemp = temperature;
            }
            display();
        }

     
        public void display()
        {
            Console.WriteLine("\n Statistics Display: \n"
                              + "Average: " + avTemp/numRead +
                              "\nMax: " + maxTemp +
                              "\nMin: " + minTemp);
        }

    }
}
