# Decorator_Pattern 

Trata-se de um padrão que tem por objetivo permitir que classes sejam estendidas com facilidade para incorporar um novo
comportamento sem mexer no código já existente, trazendo para sí o princípio aberto-fechado, que seria aberto para extensão 
e fechado para modificação.

Para isso, ele nos permite decorar/estender as caracterísitcas de uma classe, sejam estados ou comportamentos.

# Implementation

Suponhamos a criação de um app para montar um café, em que a adição de componentes acarrete o aumento do preço, o uso de heranças, em um primeiro momento, pode parecer uma boa prática.

Img 1

Entretanto, com o passar do tempo, criar novas subclasses para tudo que fosse ser implementado no café, iria causar uma catástrofe no diagrama de classe, um verdadeiro pesadelo para manutenção.

Adicionar variáveis instanciáveis para café para representar o que não é café, iria deixar o diagrama da seguinte maneira.

Img2

Como dito, primeiramente parece uma boa ideia, entretanto ele apresenta sérios problemas, como por exemplo, o que iria acontecer 
se um consumidor pedisse um mocha duplo, novos itens de decorar serão forçados a adicionar novos métodos e alterar o método getCost() 
na superclasse, entre outros.


 Para solucionar isso, iremos utilizar o Decorator Pattern.
 Img 4

 
 É possível verificar que começamos com um objeto Espresso, e após isso um objeto Mocha, após um objeto Whip e por fim Milk, ao final será computado o custo do 
usuário. De forma que chamando cost() no decorador externo, Milk, que chama o subsequênte até chegar em Expresso. 
Ao atingir Expresso, este irá retornar seu valor, 1.99, decorando com Mocha que adiciona seu valor, 0,20, decorando em seguida com Whip que retorna seu valor ,0,10,
chegando em milk que adiciona seu valor,0,10, dando resultado de 2.39.


Uma vez que este adicionar responsabilidades adicionais a um objeto de  forma dinâmica. Os Decorators fornecem uma alternativa de forma flexível de subclasse para estender a funcionalidade, de forma que será compartilhado um comportamento.
De forma que um decorador tem o mesmo supertipo que os decorados, podendo usar mais de um decorador para isso a qualquer momento. 
Dessa forma é possível, passar um objeto decorado no lugar do original.

img 3


# References

* [Software Design Patterns - Geeks for Geeks](https://www.geeksforgeeks.org/software-design-patterns/)

* Head First Design Patterns: A Brain-Friendly Guide - Eric Freeman & Elisabeth Freeman with Kathy Siera & Bert Bates
