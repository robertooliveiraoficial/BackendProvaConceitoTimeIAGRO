using BooksManager.Attributes;
using BooksManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Books.Controllers;

/// <summary>
/// BookController
/// </summary>
[Route("[controller]")]
[ApiController]
public class BookController
{
    #region Statements
    private static IEnumerable<Book> books = new List<Book>();
    private static string urlJsonFile = "https://raw.githubusercontent.com/timeiagro/BackendProvaConceitoTimeIAGRO/main/books.json";
    private static string getJsonFile = string.Empty;
    #endregion

    /// <summary>
    /// Converte(Deserializa) o arquivo .json para a classe Book
    /// </summary>
    /// <returns></returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    public static async Task<IEnumerable<Book>> JsonForBooks()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                getJsonFile = await client.GetStringAsync(urlJsonFile);

                if (getJsonFile != null)
                    books = JsonSerializer.Deserialize<IEnumerable<Book>>(getJsonFile)!;
                else
                    throw new Exception("Arquivo json não encontrado");

                if (books != null)
                    return books;
                else
                    throw new Exception("Erro ao retornar a lista de livros");
            }
            catch (Exception ex)
            {
                throw new Exception($"Aconteceu algo errado: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// - Retorna uma lista de todos os livros
    /// </summary>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("/api/books")]
    [ApiKey]
    public IEnumerable<Book> GetBooks()
    {
        return JsonForBooks().Result.ToList();
    }

    /// <summary>
    /// - Retorna uma lista de todos os livros em ordem CRESCENTE tendo o valor do campo "preço" usado como referência/parâmetro
    /// </summary>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("/api/books/price/asc")]
    [ApiKey]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IEnumerable<Book> GetBooksOrderByPriceAsc()
    {
        return JsonForBooks().Result.OrderBy(b => b.Preco).ToList();
    }

    /// <summary>
    /// - Retorna uma lista de todos os livros em ordem DECRESCENTE tendo o valor do campo "preço" usado como referência/parâmetro
    /// </summary>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("/api/books/price/desc")]
    [ApiKey]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IEnumerable<Book> GetBooksOrderByPriceDesc()
    {
        return JsonForBooks().Result.OrderByDescending(b => b.Preco).ToList();
    }

    /// <summary>
    /// - Retorna uma lista de todos os livros de acordo com o "nome do autor" passado como referência/parâmetro
    /// </summary>
    /// <param name="author">Nome do autor do livro</param>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("/api/books/author")]
    [ApiKey]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IEnumerable<Book> GetBooksByAuthorName(string author)
    {
        return JsonForBooks().Result.Where(b => b.Especificacoes!.Autor!.Contains(author, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    /// <summary>
    /// - Retorna uma lista de todos os livros de acordo com o "nome do livro" passado como referência/parâmetro
    /// </summary>
    /// <param name="name">Nome do livro</param>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("/api/books/name")]
    [ApiKey]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IEnumerable<Book> GetBooksByBookName(string name)
    {
        return JsonForBooks().Result.Where(b => b.Nome!.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    /// <summary>
    /// - Retorna uma lista de todos os livros de acordo com o "gênero" passado como referência/parâmetro
    /// </summary>
    /// <param name="genre">Gênero do livro</param>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("/api/books/genre")]
    [ApiKey]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IEnumerable<Book> GetBooksByGenre(string genre)
    {
        return JsonForBooks().Result.Where(b => b.Especificacoes!.Genres!.ToString()!.Contains(genre, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}