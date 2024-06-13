# SolProject
Esse projeto foi realizado como teste da vaga de Estágio StudioSol, onde era necessário contruir um API que fizesse o cálculo de combinações possíveis dentro de um placar de um jogo de Futebol.

A requisição é feita através de uma HTTP que retorna o resultado em formato JSON. Nesse caso, escolhi fazer em REST na linguagem C#.

Rota da API: https://localhost:{porta}/api/score/{parametro}

Para executar a API, deve-se rodar o comando no terminal "dotnet run" e verificar a porta aberta no seu local host e:

1 - Você pode pegar a URL e colar no seu navegador junto aos parâmetros de entrada. Ex: https://localhost:7126/api/score/3x7
*Observe que o parâmetro foi passado ao final e deve ser no formato {inteiro}x{inteiro}.

2 - Outra possibilidade, mais recomendada de testar é através do Postman. Caso você já o possua instalado, é somente colar a URL em uma nova Coleção e passar o parâmetro desejado.

