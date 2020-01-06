using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPaternOne.Entities
{
    class CurrentConditionsDisplay
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
            Console.WriteLine("\n CurrentConditions Display: \n"
                              + "Temp: " + temp +
                              "\nHumidity: " + humidity +
                              "\nPressure: " + pressure);
        }
    }

}
