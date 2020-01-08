# Observer_pattern

Trata-se de um padrão capaz de manter seus objetos atualizados em função de algum acontecimento, podendo, ao tempo de execução, 
manter-se informado. Um  padrão que estabelece uma dependência de um-para-muitos entre objetos.

# Implementation

Suponhamos a criação de um app que capta informações de uma estação meteorológica e notifica os usuários de informações como 
temperatura, umidade, pressão. 

<img src="https://raw.githubusercontent.com/RMiike/design-patterns/master/ObserverPaterns/assets/Observer.001.JPG" >

Imagine ainda que existam três visores que mostraram as condições meteorológicas atuais, estatísticas meteorológicas e uma possível 
previsão. 

Para isso, iremos implementar a classe WeatherData(objeto subject) e as classes responsáveis pelos visores(objetos observer) que irão exibir as condições atuais, status meteorológicos e uma previsão .


```
class WeatherData
{   public ForecastDisplay _forecastDisplay;
        public CurrentConditionsDisplay _currentConditionsDisplay;
        public StatisticsDisplay _statisticsDisplay;
        public float getTemperature()
        {
            //return 80 for simplicity
            return 80;
        }
        public float getHumidity()
        {
            //return 65 for simplicity
            return 65;
        }
        public float getPressure()
        {
            //return 30.4f for simplicity
            return 30.4f;
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
```
```
class CurrentConditionsDisplay 
    {
        private float temperature;
        private float humidity;
        private float pressure;
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

```
```
class Program
    {
        static void Main(string[] args)
        {
            
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
		forecastDisplay.display();
        }
    }
```

Entretanto, há um pequeno erro nessa implementação, uma vez que não temos como adicionar ou remover outros elementos de exibição sem fazer grandes alterações no programa. Logo a área de alteração precisa ser encapsulada.

Para isso, cria-se uma interface subject comum com a qual irão ser registrados ou removidos os observers,  em que WeatherData será implementada.
```
interface ISubject
    {
        public void registerObserver(IObserver o);
        public void removeObserver(IObserver o);
        public void notifyObserver();
    }
```


Cria-se uma interface Observer em que todos os componentes meteorológicos são implementados, bem como uma interface para todos os elementos de exibição implementar.
```
interface IObserver
    {
        public void update(float temp, float humidity, float presure);
    }
```


Para que isso funcione, a interface subject deve permanecer familiar, e todos os componentes meteorológicos implementam a interface observer, dando 

<img src= "https://raw.githubusercontent.com/RMiike/design-patterns/master/ObserverPaterns/assets/Observer.002.JPG">
