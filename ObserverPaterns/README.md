# Observer_pattern

Trata-se de um padrão capaz de manter seus objetos atualizados em função de algum acontecimento, podendo, ao tempo de execução, 
manter-se informado. Um  padrão que estabelece uma dependência de um-para-muitos entre objetos.

# Implementation

Suponhamos a criação de um app que capta informações de uma estação meteorológica e notifica os usuários de informações como 
temperatura, umidade, pressão. 

Imagine ainda que existam três visores que mostraram as condições meteorológicas atuais, estatísticas meteorológicas e uma possível 
previsão. 

Para isso, iremos implementar a classe WeatherData(objeto subject) e as classes responsáveis pelos visores(objetos observer).
O Subject é responsável por gerenciar dados, e os Observers são registrados junto ao subject para receber atualizações quando os 
dados são alterados.
