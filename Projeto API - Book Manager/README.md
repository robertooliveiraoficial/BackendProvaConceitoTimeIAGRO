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
- Insira essa url: <applicationUrl>/api/books;
- Na aba "Authorization", na opção "Type", escolha "API Key". Na opção "Key", insira o parâmetro "api_key"(sem aspas), na coluna "Value", insira o valor "BackendProvaConceitoTimeIAGRO_IlTevUM/z0ey3NwCV/unWg=="(sem aspas)
- Clique em SEND;

-- TRAZER TODOS OS LIVROS EM ORDEM CRESCENTE(ASC)
-------------------------------------------------
- Crie uma nova aba de request do tipo HTTP;
- Selecione método GET;
- Insira essa url: <applicationUrl>/api/books/price/asc;
- Na aba "Authorization", na opção "Type", escolha "API Key". Na opção "Key", insira o parâmetro "api_key"(sem aspas), na coluna "Value", insira o valor "BackendProvaConceitoTimeIAGRO_IlTevUM/z0ey3NwCV/unWg=="(sem aspas)
- Clique em SEND;

-- TRAZER TODOS OS LIVROS EM ORDEM DECRESCENTE(DESC)
----------------------------------------------------
- Crie uma nova aba de request do tipo HTTP;
- Selecione método GET;
- Insira essa url: <applicationUrl>/api/books/price/desc;
- Na aba "Authorization", na opção "Type", escolha "API Key". Na opção "Key", insira o parâmetro "api_key"(sem aspas), na coluna "Value", insira o valor "BackendProvaConceitoTimeIAGRO_IlTevUM/z0ey3NwCV/unWg=="(sem aspas)
- Clique em SEND;

-- TRAZER TODOS OS LIVROS PELO NOME DO AUTOR
--------------------------------------------
- Crie uma nova aba de request do tipo HTTP;
- Selecione método GET;
- Insira essa url: <applicationUrl>/api/books/author;
- Na aba "Authorization", na opção "Type", escolha "API Key". Na opção "Key", insira o parâmetro "api_key"(sem aspas), na coluna "Value", insira o valor "BackendProvaConceitoTimeIAGRO_IlTevUM/z0ey3NwCV/unWg=="(sem aspas)
- Na aba "Params", na coluna "Key", logo abaixo, insira o nome de outro parâmetro, nesse caso "author"(sem aspas), na coluna "Value", insira o nome do autor(Ex.: Rowling).
- Clique em SEND;

-- TRAZER TODOS OS LIVROS PELO NOME DO LIVRO
--------------------------------------------
- Crie uma nova aba de request do tipo HTTP;
- Selecione método GET;
- Insira essa url: <applicationUrl>/api/books/name;
- Na aba "Authorization", na opção "Type", escolha "API Key". Na opção "Key", insira o parâmetro "api_key"(sem aspas), na coluna "Value", insira o valor "BackendProvaConceitoTimeIAGRO_IlTevUM/z0ey3NwCV/unWg=="(sem aspas)
- Na aba "Params", na coluna "Key", logo abaixo, insira o nome de outro parâmetro, nesse caso "name"(sem aspas), na coluna "Value", insira o nome do livro(Ex.: Harry).
- Clique em SEND;

-- TRAZER TODOS OS LIVROS PELO GÊNERO
-------------------------------------
- Crie uma nova aba de request do tipo HTTP;
- Selecione método GET;
- Insira essa url: <applicationUrl>/api/books/genre;
- Na aba "Authorization", na opção "Type", escolha "API Key". Na opção "Key", insira o parâmetro "api_key"(sem aspas), na coluna "Value", insira o valor "BackendProvaConceitoTimeIAGRO_IlTevUM/z0ey3NwCV/unWg=="(sem aspas)
- Na aba "Params", na coluna "Key", logo abaixo, insira o nome de outro parâmetro, nesse caso "genre"(sem aspas), na coluna "Value", insira a descrição do gênero(Ex.: Adventure).
- Clique em SEND;








