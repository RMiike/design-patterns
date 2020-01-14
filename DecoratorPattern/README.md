# Decorator_Pattern 

Trata-se de um padrão que tem por objetivo permitir que classes sejam estendidas com facilidade para incorporar um novo
comportamento sem mexer no código já existente, trazendo para sí o princípio aberto-fechado, que seria aberto para extensão 
e fechado para modificação.

Para isso, ele nos permite decorar/estender as caracterísitcas de uma classe, sejam estados ou comportamentos.

# Implementation

Suponhamos a criação de um app para montar um café, em que a adição de componentes acarrete o aumento do preço, o uso de heranças, em um primeiro momento, pode parecer uma boa prática.

<img src="https://raw.githubusercontent.com/RMiike/design-patterns/master/DecoratorPattern/assets/Decorator.001.JPG">
Entretanto, com o passar do tempo, criar novas subclasses para tudo que fosse ser implementado no café, iria causar uma catástrofe no diagrama de classe, um verdadeiro pesadelo para manutenção.

Adicionar variáveis instanciáveis para café para representar o que não é café, iria deixar o diagrama da seguinte maneira.

<img src="https://raw.githubusercontent.com/RMiike/design-patterns/master/DecoratorPattern/assets/Decorator.002.JPG">

Como dito, primeiramente parece uma boa ideia, entretanto ele apresenta sérios problemas, como por exemplo, o que iria acontecer 
se um consumidor pedisse um mocha duplo, novos itens de decorar serão forçados a adicionar novos métodos e alterar o método getCost() 
na superclasse, entre outros.


 Para solucionar isso, iremos utilizar o Decorator Pattern.
 
<img src="https://raw.githubusercontent.com/RMiike/design-patterns/master/DecoratorPattern/assets/Decorator.004.JPG">
 
 É possível verificar que começamos com um objeto Espresso, e após isso um objeto Mocha, após um objeto Whip e por fim Milk, ao final será computado o custo do 
usuário. De forma que chamando cost() no decorador externo, Milk, que chama o subsequênte até chegar em Expresso. 
Ao atingir Expresso, este irá retornar seu valor, 1.99, decorando com Mocha que adiciona seu valor, 0,20, decorando em seguida com Whip que retorna seu valor ,0,10,
chegando em milk que adiciona seu valor,0,10, dando resultado de 2.39.


Uma vez que este adicionar responsabilidades adicionais a um objeto de  forma dinâmica. Os Decorators fornecem uma alternativa de forma flexível de subclasse para estender a funcionalidade, de forma que será compartilhado um comportamento.
De forma que um decorador tem o mesmo supertipo que os decorados, podendo usar mais de um decorador para isso a qualquer momento. 
Dessa forma é possível, passar um objeto decorado no lugar do original.


<img src="https://raw.githubusercontent.com/RMiike/design-patterns/master/DecoratorPattern/assets/Decorator.003.JPG">

Para implementar  o código, começamos com a classe abstrata principal Beverage, que é abstrata e possui os métodos virtual getDescription() e abstract cost(), já que não queremos dar uma implementação a cost(), uma vez que precisamos saber o tipo de Beverage que queremos.

```
abstract class Beverage
    {


        private string _description = "Unknown Beverage";
  

    
        public  virtual string getDescription
        {
            get { return _description; } 
        }

        public abstract double cost();

       
    }
```
Agora temos o Abstract Decorator, classe abstrata também (Condiment Decorator), que serão intercambiáveis com Beverage, logo será estendido de Beverage.
Exige-se também que todos os decoradores implementem o método getDescription.

```
  abstract class CondimentDecorator : Beverage
    {
        string _description = "Abstract Condiment Decorator";
        public override string getDescription
        {
            get { return _description; }
        }
    }
```
Em seguida, implementa-se as bebidas principais, podendo citar como exemplo o DarkRoast, que estende Beverage e é um componente concreto, uma vez que se trata de uma bebida, logo não será necessário calcular os adicionais, apenas iremos retornar o preço, ou seja, $ 0.99.
A descrição será feita ao herdar o método getDescription, que será substituída em uma classe derivada com a propriedade declarada  _description. 


```
class DarkRoast : Beverage
    {

        string _description = "Dark Roast Coffe";
    
        public override double cost()
        {
            return .99;
        }

        public override string getDescription
        {
            get { return _description; }
        }

    }
```
Por fim os decoradores concretos,  que iremos utilizar como exemplo Mocha.
Por se tratar de um decorador, este ira estender o decorador abstrato, que estendeu Beverage.
Para iniciar, iremos criar uma instância de Mocha com referência a Beverage, e uma variável de instância para conter a bebida que está sendo envelopada.
Em seguida passamos o custo da bebida que foi pedida( com _beverage.cost()) delegando a chamada para o objeto que está sendo decorado, para que em seguida possa somar ao custo de Mocha.
O mesmo é utilizado para o método getDesciption que irá acrescentar ao nome contido no objeto que está sendo decorado a palavra “, Mocha”.

```
class Mocha : CondimentDecorator
            {
        Beverage _beverage;
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override double cost()
        {
            return _beverage.cost() + .20;
        }
        public override string getDescription
        {
            get
            {
                return _beverage.getDescription + ", Mocha";
            }
        }
    }
```
Aqui se encontram alguns códigos de teste, em que eu peço um expresso em um decorador e imprime apenas a descrição e o preço e em seguida o pedido de Dark Roast com os decoradores em sequência e o respectivo acréscimo de valor.
```
static void Main(string[] args)
        {

            Beverage beverage = new Expresso();

            System.Console.WriteLine(beverage.getDescription + " $ " + beverage.cost());


            Beverage beverage1 = new DarkRoast();
            System.Console.WriteLine(beverage1.getDescription + " $ " + beverage1.cost());
            beverage1 = new Mocha(beverage1); 
            System.Console.WriteLine(beverage1.getDescription  + " $ "  + beverage1.cost());

             beverage1 = new Milk(beverage1);
            System.Console.WriteLine(beverage1.getDescription  + " $ " + beverage1.cost());

            beverage1 = new Soy(beverage1);

            System.Console.WriteLine(beverage1.getDescription +" $ " +beverage1.cost());
            beverage1 = new Whip(beverage1);

            System.Console.WriteLine(beverage1.getDescription + " $ " + beverage1.cost());

        }

```


# References

* [Software Design Patterns - Geeks for Geeks](https://www.geeksforgeeks.org/software-design-patterns/)

* Head First Design Patterns: A Brain-Friendly Guide - Eric Freeman & Elisabeth Freeman with Kathy Siera & Bert Bates
