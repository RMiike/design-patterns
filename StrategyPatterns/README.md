# Strategy_Patterns

Nesse padrão de projeto a classe comportamento pode ser mudada no momento de sua execução em tempo real.
Cria-se um objeto cliente que possui diversas estratégias e um objeto contexto com comportamento variável, dessa forma o objeto principal altera o algoritmo de execução do objeto contexto.



# Exemplo prático

Para simplificar, vamos examinar o exemplo Design Puzzle do livro Padrões de Projetos (Design Patterns).

<img src="https://i.ibb.co/cyNJd4B/puzzle3.jpg" >

Presume-se que todos os pesonagens podem executar a ação fight, logo a superclasse cuidará do código de implementação. O método display() é abstrato, já que todos os personagens são diferentes. 


Cada subtipo de Character é responsável por implementar seu próprio comportamento display para o modo como aparece na tela.

Caso seja necessário implementar uma ação de ataque e defesa, seria necessário modificar o método fight(), uma vez que cada arma ou personagem iria agir de uma forma diferente, uma vez que seria estranho apresentar uma defesa com um personagem de arco e flecha.

Para tal situação, utilizar herança não é a resposta correta, uma vez que seria necessário realizar alteração nos diversos personagens.
Seria ncessário utilizar um método que cause o menor impacto no código exitente. Perder menos tempo. Buscar desenvolver para crescer com o tempo e nao morrer.

Dessa forma, a solução mais viável é "pegar o que variar e encapsular para não afetar o resto do código", fazendo-se necessário identificar os aspectos de sua aplicação e "separar o que muda do que fica igual".



Vale ressaltar que criar diversas classes comportamentais não é uma boa prática, uma vez que o uso do polimorfismo na classe “behavior” será perdido.












Para que isso não ocorra, busca-se programar para uma interface e não para uma implementação ou supertipo.
encapsular





<img src="https://www.oreilly.com/library/view/head-first-design/0596007124/figs/web/025fig01.png.jpg">

<img src="https://i.ibb.co/BfHHRmt/Puzzle.jpg" >

<img src="https://i.ibb.co/60DTRVg/puzzle2.jpg" >

