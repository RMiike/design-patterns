# Strategy_Patterns

Nesse padrão de projeto a classe comportamento pode ser mudada no momento de sua execução em tempo real.
Cria-se um objeto cliente que possui diversas estratégias e um objeto contexto com comportamento variável, dessa forma o objeto principal altera o algoritmo de execução do objeto contexto.



# Implementation

Para simplificar, vamos examinar o exemplo Design Puzzle do livro Padrões de Projetos (Design Patterns).

<img src="https://raw.githubusercontent.com/RMiike/design-patterns/master/StrategyPatterns/assets/StrategyPatternPic.jpg" >

Presume-se que todos os pesonagens podem executar a ação fight, logo a superclasse cuidará do código de implementação. O método display() é abstrato, já que todos os personagens são diferentes. 


Cada subtipo de Character é responsável por implementar seu próprio comportamento display para o modo como aparece na tela.

Caso seja necessário implementar uma ação de ataque e defesa, seria necessário modificar o método fight(), uma vez que cada arma ou personagem iria agir de uma forma diferente, uma vez que seria estranho apresentar uma defesa com um personagem de arco e flecha.

Para tal situação, utilizar herança não é a resposta correta, uma vez que seria necessário realizar alteração nos diversos personagens.
Seria ncessário utilizar um método que cause o menor impacto no código exitente. Perder menos tempo. Buscar desenvolver para crescer com o tempo e nao morrer.

Dessa forma, a solução mais viável é "pegar o que variar e encapsular para não afetar o resto do código", fazendo-se necessário identificar os aspectos de sua aplicação e "separar o que muda do que fica igual".

<img src="https://raw.githubusercontent.com/RMiike/design-patterns/master/StrategyPatterns/assets/StrategyPatternPic%20(2).jpg" >

A partir de agora, os comportamentos ficam em uma classe separada que implementa uma interface de comportamento. Assim as classes não precisam dos detalhes de implementaçao para seu comportamento. Tornando-se mais flexiveis. 
Na classe Character é que será criada a propriedade do tipo weaponBehavior.
Assim, será possível ensinar os personagens como usar as armas em defesa ou ataque

<img src="https://raw.githubusercontent.com/RMiike/design-patterns/master/StrategyPatterns/assets/StrategyPatternPic%20(1).jpg" >

As classes de ordenação implementam a interface IWeaponBehavior.

```
interface IWeaponBehavior
    {
        void useWeapon();
    }
 ```
```
     class BowAndArrowBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            System.Console.WriteLine("Shooting with an arrow!");
        }
    }
      class KnifwBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            System.Console.WriteLine("Cutting with a knife!");
        }
    }
     class SwordBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            System.Console.WriteLine("Swing a sword!");
        }
    }
     class AxeBehavior : IWeaponBehavior
    {
       
    public void useWeapon()
        {
            System.Console.WriteLine("Choping with an axe!");
        }
    }
    

```



Perceba que a classse Character recebe em seu construtor qual sera o comportamento de ordenação que será aplicado, e ainda delega a responsabilidade de ordenação a essa interface.

```
 abstract class Character
    {

        public IWeaponBehavior _weaponBehavior;

        public Character()
        {

        }

        public abstract void figh();

        public void setWeapon(IWeaponBehavior weaponBehavior)
        {
            this._weaponBehavior = weaponBehavior;
        }

    }
```

Por fim, verifica-se que o Character simplesmente alterna entre os comportamentos de armas estabelecidos, sem adicionar nenhuma outra funcionalidade.

```
class Program
    {
        static void Main(string[] args)
        {
            Character queen = new Queen();
            queen.setWeapon(new BowAndArrowBehavior()) ;
            queen.figh();
            Character king = new King();
            king.setWeapon(new AxeBehavior());
            king.figh();
            Character king2 = new King();
            king.setWeapon(new SwordBehavior());
            king2.figh();
            Character knight = new Knight();
            knight.setWeapon(new SwordBehavior());
            knight.figh();
            Character troll = new Troll();
            troll.setWeapon(new KnifwBehavior());
            troll.figh();
        }
    }
    
```



# References
* [abishekaditya - DesignPatterns](https://github.com/abishekaditya/DesignPatterns)

* [Software Design Patterns - Geeks for Geeks](https://www.geeksforgeeks.org/software-design-patterns/)

* Head First Design Patterns: A Brain-Friendly Guide - Eric Freeman & Elisabeth Freeman with Kathy Siera & Bert Bates

* [15 Design Patterns para Você Impulsionar seu Código C# no Mundo Real](https://www.fabiosilvalima.net/design-patterns-no-mundo-real/)
