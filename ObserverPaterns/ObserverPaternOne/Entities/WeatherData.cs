using ObserverPaternOne.Entities;

namespace ObserverPaternOne.Entities
{
    class WeatherData
    {
        public ForecastDisplay _forecastDisplay;
        public CurrentConditionsDisplay _currentConditionsDisplay;
        public StatisticsDisplay _statisticsDisplay;
        public float getTemperature()
        {
            return 0;
        }
        public float getHumidity()
        {
            return 0;
        }
        public float getPressure()
        {
            return 0;
        }
        public void mensurementsChanged()
        {
            float temp = getTemperature();
            float humidity = getHumidity();
            float pressure = getPressure();

            _currentConditionsDisplay.update(temp, humidity, pressure);
            _statisticsDisplay.update(temp, humidity, pressure);
            _forecastDisplay.update(temp, humidity, pressure);
        }

        
    }
}
