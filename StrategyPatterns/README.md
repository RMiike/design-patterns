# Strategy_Patterns

Nesse padrão de projeto a classe comportamento pode ser mudada no momento de sua execução em tempo real.
Cria-se um objeto cliente que possui diversas estratégias e um objeto contexto com comportamento variável, dessa forma o objeto principal altera o algoritmo de execução do objeto contexto.



# Exemplo prático

Vamos examinar o exemplo Design Puzzle do livro Padrões de Projetos (Design Patterns).
Primeiramente, vale ressaltar que criar diversas classes comportamentais não é uma boa prática, uma vez que o uso do polimorfismo na classe “behavior” será perdido.
Para que isso não ocorra, busca-se programar para uma interface e não para uma implementação ou supertipo.

<a href="https://ibb.co/b6jjnxP"><img src="https://i.ibb.co/BfHHRmt/Puzzle.jpg" alt="Puzzle" border="0"></a>

Dessa forma, é necessário identificar os aspectos de sua aplicação e "separar o que muda do que fica igual".
