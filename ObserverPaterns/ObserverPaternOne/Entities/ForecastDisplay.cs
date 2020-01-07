using ObserverPaternOne.Interfaces;

namespace ObserverPaternOne.Entities
{
    class ForecastDisplay : IObserver, IDisplayElement
    {
        private ISubject _weatherData;
        private float temperature;
        private float humidity;
        private float pressure;
        private float forecast = 29.92f;
        private float forecast2;


        public ForecastDisplay(ISubject weatherData)
        {
            this._weatherData = weatherData;
            this._weatherData.registerObserver(this);
        }
        public void update(float temperature, float humidity, float pressure)
        {
            forecast2 = forecast;
            forecast = pressure;

            display();

        }

        public void display()
        {
            System.Console.WriteLine("Forecast: ");
            if (forecast > forecast2)
            {
                System.Console.WriteLine("Improving weather on the way!");
            }
            else if (forecast == forecast2)
            {
                System.Console.WriteLine("More of the same");
            }
            else if (forecast < forecast2)
                System.Console.WriteLine("Watch out for cooler, rainy weather");

        }

    }
}
