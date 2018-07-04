# Delivery Service

Api para gerenciamento e manutencao de rotas entre sistemas, o sistema possibilita a criação de servicos e rotas para o mesmos, tambem disponibiliza a melhor rota entre dois pontos pre-definidos.

## Desenvolvimento da Webapi

Webapi desenvolvida em asp.net core, usando Mediatr para comunicação via mensagens, Banco de dados SQL Server com entity framework e Swagger para mapeamento das rotas.

## Executando o webapi.

1º opção : 

    Abrir a aplicação no Visual studio alterar a string de conexao para um endereço SQL server válido e executar o webapi

2º opção :

    * Necessario Docker e docker-compose instalado.

    No prompt de comando navegue até a pasta raiz da aplicação e execute o seguinte comando:

    $ docker-compose up

    e acessar http://localhost:8080/swagger/index.html

