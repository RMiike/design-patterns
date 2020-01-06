using ObserverPaternOne.Entities;

namespace ObserverPaternOne
{
    class Program
    {
        static void Main(string[] args)
        {
            ForecastDisplay forecastDisplay = new ForecastDisplay();
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay();
            forecastDisplay.display();
        }
    }
}
