MinutradeTesteTecnico
=====================

Teste técnico a ser submetido à Minutrade


O projeto se divide em
- Core
- Data
- MinutradeService
- UI

O projeto MinutradeService é serviço rest implementado utilizando o .Net WebApi
Na pasta UI se encontra um exemplo de consumo dos serviços fornecidos através das chamadas no padrão {uri do serviço} +
- GET /api/Clientes -busca todos clientes
- GET /api/Clientes/{id} - busca cliente por id
- PUT /api/Clientes/{id} + objeto cliente a ser descerializado pelo serviço
