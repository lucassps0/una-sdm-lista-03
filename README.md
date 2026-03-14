Centro Universitário UNA
Sistemas Distribuídos e Mobile
Professor Daniel Henrique Matos de Paiva
Lista de Exercícios III

Exercícios:

Atividade: "O Restaurante Assíncrono"
Imagine que estamos construindo um sistema de pedidos para um
restaurante internacional onde o Cliente (Client) fala português, o Garçom
(Middleware/API) fala inglês e o Cozinheiro (Server) só entende códigos de
receitas.
Parte 1: Analogia de Conceitos
Relacione os termos técnicos com os elementos do nosso restaurante:

1. HTTP (O Protocolo): É o manual de etiqueta e o idioma padrão. Ele
define como o cliente deve chamar o garçom, como o pedido deve ser
entregue e quais são as respostas possíveis (ex: "Aqui está", "Acabou o
prato", "Não entendi seu pedido").

3. API (A Interface): É o cardápio. O cliente não entra na cozinha para
mexer nas panelas (segurança e encapsulamento). Ele olha o cardápio,
vê o que está disponível e faz a requisição através do garçom.

4. JSON (O Formato): É a comanda. Não importa se o garçom anota em
um tablet ou papel, ele usa um formato padronizado que tanto o cliente
quanto o cozinheiro conseguem ler rapidamente.

Parte 2: Desafio Prático Teórico
Considere o seguinte cenário em C#: você está desenvolvendo um serviço que
gerencia uma biblioteca distribuída.

1. O Verbo Correto (HTTP Methods)
Se você quer cadastrar um novo livro no sistema via API, qual método HTTP
você deve usar e por quê?
• (A) GET
• (B) POST
• (C) DELETE

3. Decifrando a Comanda (JSON)
Abaixo está um exemplo de como os dados de um livro viajam entre o
servidor e o cliente. Identifique os erros de sintaxe neste JSON para que o C#
consiga desserializá-lo corretamente:

JSON
{
"titulo": "Sistemas Distribuídos",
"autor": "Andrew Tanenbaum"
"edicao" 4,
"disponivel": true
}

3. O Status da Entrega (HTTP Status Codes)
Sua aplicação C# tentou buscar um livro que não existe no banco de dados.
Qual Código de Status HTTP a sua API deve retornar para o usuário para ser
considerada uma aplicação bem projetada?
• ( ) 200 OK
• ( ) 404 Not Found
• ( ) 500 Internal Server Error

Parte 3: Pensamento Arquitetural (C# Context)
Em C#, usamos frequentemente a classe HttpClient para consumir dados e o
ASP.NET Core Web API para fornecê-los.
Pergunta Discursiva:
Imagine que o servidor de banco de dados da biblioteca caiu. Se um aluno
tentar buscar um livro, a API deve retornar um erro de "Página não
encontrada" (404) ou um "Erro interno do servidor" (500)? Justifique sua
resposta pensando na transparência de falhas em Sistemas Distribuídos.
