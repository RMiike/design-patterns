using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPaternOne.Entities
{
    class StatisticsDisplay
    {
        public float temp { get; set; }
        public float humidity { get; set; }
        public float pressure { get; set; }
        public void update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public void display()
        {
            Console.WriteLine("\n Statistics Display: \n"
                              + "Temp: " + temp +
                              "\nHumidity: " + humidity +
                              "\nPressure: " + pressure);
        }

    }
}
