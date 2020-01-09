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

<img src= "https://raw.githubusercontent.com/RMiike/design-patterns/master/ObserverPaterns/assets/Observer.002.JPG">

Para isso, cria-se uma interface subject comum com a qual irão ser registrados ou removidos os observers,  em que WeatherData será implementada.

```
interface ISubject
    {
        public void registerObserver(IObserver o);
        public void removeObserver(IObserver o);
        public void notifyObserver();
    }
```
Os sujeitos concretos sempre implementam esta interface para serem registrados, removidos. Além disso, o sujeito concreto implementa um método notify, que é utilizado para atualizar todos os observers registrados, podendo também possuir métodos para definir e obter o sue estado. 

Cria-se uma interface Observer em que todos os componentes meteorológicos são implementados, bem como uma interface para todos os elementos de exibição implementar.
```
interface IObserver
    {
        public void update(float temp, float humidity, float presure);
    }
```

Os observers concretos implementam essa interface, ressaltando que esta interface possui apenas o método update(), que é chamado quando alterado o estado do Subject.

Agora, implementa-se a classe WeatherData com o Padrão Observer, implementa-se a interface Subject, adiciona-se uma lista para conter os observers  juntamente com um construtor. Adicionando uma lista de observes que são registrados. 

```
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
```	

Um comando apenas para adicionar o observador registrado ao final da lista, bem como removido .

```

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

```

Esse método é onde os Observers são notificados, logo após obter a medição atualizada das estações.

```



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
```

Os elementos de exibição precisão implementar a interface Observer para receber as mudanças de WeatherData, e a interface DisplayElement, responsável pela exibição.

O construtor recebe o objeto WeatherData para ser registrado como um objserver.
Ao chamar o método update(). a temperatura, humidade e pressão são salvos, e em seguida é chamado o método display(), responsável pela exibição.


```
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
```

Para exibir o funcionamento, primeiro cria-se o objeto WeatherData, criar a exibição que será passada para o objeto criado e em seguida simulado.


```
 static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);
            weatherData.setMesurements(80, 65, 30.4f);
            weatherData.setMesurements(82, 70, 29.2f);
            weatherData.setMesurements(78, 90, 29.2f);
        }
```




# References
* [Christopher Okhravi - Design Patterns](https://www.youtube.com/channel/UCbF-4yQQAWw-UnuCd2Azfzg/videos)

* [abishekaditya - DesignPatterns](https://github.com/abishekaditya/DesignPatterns)

* [Software Design Patterns - Geeks for Geeks](https://www.geeksforgeeks.org/software-design-patterns/)

* Head First Design Patterns: A Brain-Friendly Guide - Eric Freeman & Elisabeth Freeman with Kathy Siera & Bert Bates

* [15 Design Patterns para Você Impulsionar seu Código C# no Mundo Real](https://www.fabiosilvalima.net/design-patterns-no-mundo-real/)
