# BooksManager
-------------------------------------------------------------------------------------------------------------------------------------------------------------------
/* --- CRIAÇÃO DO PROJETO ---*/
-------------------------------------------------------------------------------------------------------------------------------------------------------------------
- Projeto criado no Visual Studio 2022 Community;
  - API Web do ASP.NET Core;
  - .NET 6.0;

-------------------------------------------------------------------------------------------------------------------------------------------------------------------
/* --- TESTES POSTMAN ---*/
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

** <applicationUrl> = ENDEREÇO LOCAL E A PORTA QUE A APLICAÇÃO IRÁ USAR: "https://localhost:<PORTA>"(ENCONTRA-SE NA PASTA PROPERTIES, NO ARQUIVO launchSettings.json);

-- TRAZER TODOS OS LIVROS
-------------------------
- Crie uma nova aba de request do tipo HTTP;
- Selecione método GET;
- Insira essa url: <applicationUrl>/Book/GetBooks;
- Clique em SEND;

-- TRAZER TODOS OS LIVROS EM ORDEM CRESCENTE(ASC)
-------------------------------------------------
- Crie uma nova aba de request do tipo HTTP;
- Selecione método GET;
- Insira essa url: <applicationUrl>/Book/OrderByPriceAsc;
- Clique em SEND;

-- TRAZER TODOS OS LIVROS EM ORDEM DECRESCENTE(DESC)
----------------------------------------------------
- Crie uma nova aba de request do tipo HTTP;
- Selecione método GET;
- Insira essa url: <applicationUrl>/Book/OrderByPriceDesc;
- Clique em SEND;

-- TRAZER TODOS OS LIVROS PELO NOME DO AUTOR
--------------------------------------------
- Crie uma nova aba de request do tipo HTTP;
- Selecione método GET;
- Insira essa url: <applicationUrl>/Book/GetBooksByAuthorName;
- Na aba "Params", na coluna "Key", insira o nome do parâmetro, nesse caso "author"(sem aspas), na coluna "Value", insira o nome do autor(Ex.: Rowling).
- Clique em SEND;

-- TRAZER TODOS OS LIVROS PELO NOME DO LIVRO
--------------------------------------------
- Crie uma nova aba de request do tipo HTTP;
- Selecione método GET;
- Insira essa url: <applicationUrl>/Book/GetBooksByBookName;
- Na aba "Params", na coluna "Key", insira o nome do parâmetro, nesse caso "bookName"(sem aspas), na coluna "Value", insira o nome do livro(Ex.: Harry).
- Clique em SEND;

-- TRAZER TODOS OS LIVROS PELO GÊNERO
-------------------------------------
- Crie uma nova aba de request do tipo HTTP;
- Selecione método GET;
- Insira essa url: <applicationUrl>/Book/GetBooksByGenre;
- Na aba "Params", na coluna "Key", insira o nome do parâmetro, nesse caso "genre"(sem aspas), na coluna "Value", insira a descrição do gênero(Ex.: Adventure).
- Clique em SEND;

-------------------------------------------------------------------------------------------------------------------------------------------------------------------
/* --- TESTES SWAGGER ---*/
-------------------------------------------------------------------------------------------------------------------------------------------------------------------
- Compile a aplicação;
- Inicie sem depurar, feito isso irá ser apresentado a tela do SWAGGER na seguinte url: <applicationUrl>/swagger/index.html;
- Nessa tela irá ser apresentado o nome do projeto, nesse caso, BOOKS MANAGER, e os respectivos métodos.

-- TRAZER TODOS OS LIVROS
-------------------------
Clique em: 
- GET ​/Book​/GetBooks;
- Try it out(Para habilitar as opções);
- EXECUTE;

-- TRAZER TODOS OS LIVROS EM ORDEM CRESCENTE(ASC)
-------------------------------------------------
Clique em: 
GET ​/Book​/OrderByPriceAsc;
- Try it out(Para habilitar as opções);
- EXECUTE;

-- TRAZER TODOS OS LIVROS EM ORDEM DECRESCENTE(DESC)
----------------------------------------------------
Clique em: 
GET ​/Book​/OrderByPriceDesc;
- Try it out(Para habilitar as opções);
- EXECUTE;

-- TRAZER TODOS OS LIVROS PELO NOME DO AUTOR
--------------------------------------------
Clique em: 
GET ​/Book​/GetBooksByAuthorName;
- Try it out(Para habilitar as opções);
- Habilitando irá liberar uma aba(Params):
  - Será apresentado duas colunas:
    - "Name":
      -------
       - apresenta o nome e o tipo do parâmetro;
       - apresenta
    - "Description":
      --------------
       - onde será passado o valor do parâmetro;          
- Após inserir o parâmetro, clique em: EXECUTE;
- Logo abaixo em RESPONSES será apresentado o retorno da consulta;

-- TRAZER TODOS OS LIVROS PELO NOME DO LIVRO
--------------------------------------------
Clique em: 
GET ​/Book​/GetBooksByBookName;
- Try it out(Para habilitar as opções);
- Habilitando irá liberar uma aba(Params):
  - Será apresentado duas colunas:
    - "Name":
      -------
       - apresenta o nome e o tipo do parâmetro;
       - apresenta
    - "Description":
      --------------
       - onde será passado o valor do parâmetro;          
- Após inserir o parâmetro, clique em: EXECUTE;
- Logo abaixo em RESPONSES será apresentado o retorno da consulta;

-- TRAZER TODOS OS LIVROS PELO GÊNERO
-------------------------------------
Clique em: 
GET ​/Book​/GetBooksByGenre;
- Try it out(Para habilitar as opções);
- Habilitando irá liberar uma aba(Params):
  - Será apresentado duas colunas:
    - "Name":
      -------
       - apresenta o nome e o tipo do parâmetro;
       - apresenta
    - "Description":
      --------------
       - onde será passado o valor do parâmetro;          
- Após inserir o parâmetro, clique em: EXECUTE;
- Logo abaixo em RESPONSES será apresentado o retorno da consulta;








