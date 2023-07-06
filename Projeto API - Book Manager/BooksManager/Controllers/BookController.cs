using BooksManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BooksManager.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    #region Declarações
    private static List<Book> books = new List<Book>();
    private static string urlJson = "https://raw.githubusercontent.com/timeiagro/BackendProvaConceitoTimeIAGRO/main/books.json";
    #endregion

    /// <summary>
    /// - Retorna uma lista de todos os livros
    /// </summary>
    /// <param name="No Params">No Params</param>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("GetBooks")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<List<Book>> JsonForBooks()
    {
        var getJson = string.Empty;
        var getJsonFile = await new HttpClient().GetStringAsync(urlJson);
        books = JsonSerializer.Deserialize<List<Book>>(getJsonFile)!;
        return books;
    }

    /// <summary>
    /// - Retorna uma lista de todos os livros em ordem CRESCENTE tendo o valor do campo "preço" usado como referência/parâmetro
    /// </summary>
    /// <param name="No Params">No Params</param>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("OrderByPriceAsc")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<List<Book>> GetBooksOrderByPriceAsc()
    {
        var getJson = string.Empty;
        var getJsonFile = await new HttpClient().GetStringAsync(urlJson);

        books = JsonSerializer.Deserialize<List<Book>>(getJsonFile)!;
        
        return books.OrderBy(b => b.Preco).ToList();
    }

    /// <summary>
    /// - Retorna uma lista de todos os livros em ordem DECRESCENTE tendo o valor do campo "preço" usado como referência/parâmetro
    /// </summary>
    /// <param name="No Params">No Params</param>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("OrderByPriceDesc")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<List<Book>> GetBooksOrderByPriceDesc()
    {
        var getJson = string.Empty;
        var getJsonFile = await new HttpClient().GetStringAsync(urlJson);

        books = JsonSerializer.Deserialize<List<Book>>(getJsonFile)!;
        return books.OrderByDescending(b => b.Preco).ToList();            
    }

    /// <summary>
    /// - Retorna uma lista de todos os livros de acordo com o "nome do autor" passado como referência/parâmetro
    /// </summary>
    /// <param name="author">Nome do autor do livro</param>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("GetBooksByAuthorName")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<List<Book>> GetBooksByAuthorName(string author)
    {
        var getJson = string.Empty;
        var getJsonFile = await new HttpClient().GetStringAsync(urlJson);

        books = JsonSerializer.Deserialize<List<Book>>(getJsonFile)!;

        return books.Where(b => b.Especificacoes!.Autor!.Contains(author, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    /// <summary>
    /// - Retorna uma lista de todos os livros de acordo com o "nome do livro" passado como referência/parâmetro
    /// </summary>
    /// <param name="bookName">Nome do livro</param>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("GetBooksByBookName")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<List<Book>> GetBooksByBookName(string bookName)
    {
        var getJson = string.Empty;
        var getJsonFile = await new HttpClient().GetStringAsync(urlJson);

        books = JsonSerializer.Deserialize<List<Book>>(getJsonFile)!;

        return books.Where(b => b.Nome!.Contains(bookName, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    /// <summary>
    /// - Retorna uma lista de todos os livros de acordo com o "gênero" passado como referência/parâmetro
    /// </summary>
    /// <param name="genre">Gênero do livro</param>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("GetBooksByGenre")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<List<Book>> GetBooksByGenre(string genre)
    {
        var getJson = string.Empty;
        var getJsonFile = await new HttpClient().GetStringAsync(urlJson);

        books = JsonSerializer.Deserialize<List<Book>>(getJsonFile)!;

        return books.Where(b => b.Especificacoes!.Genres!.ToString()!.Contains(genre, StringComparison.OrdinalIgnoreCase)).ToList();
    }    
}
