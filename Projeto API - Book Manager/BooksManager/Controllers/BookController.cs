using BooksManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BooksManager.Controllers;

/// <summary>
/// BookController
/// </summary>
[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    #region Statements
    private static IEnumerable<Book> books = new List<Book>();
    private static string urlJsonFile = "https://raw.githubusercontent.com/timeiagro/BackendProvaConceitoTimeIAGRO/main/books.json";
    #endregion

    /// <summary>
    /// - Retorna uma lista de todos os livros
    /// </summary>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("/api/books")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IEnumerable<Book>> JsonForBooks()
    {        
        var getJsonFile = await new HttpClient().GetStringAsync(urlJsonFile);
        books = JsonSerializer.Deserialize<IEnumerable<Book>>(getJsonFile)!;
        return books;
    }
    
    /// <summary>
    /// - Retorna uma lista de todos os livros em ordem CRESCENTE tendo o valor do campo "preço" usado como referência/parâmetro
    /// </summary>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("/api/books/price/asc")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IEnumerable<Book>> GetBooksOrderByPriceAsc()
    {        
        var getJsonFile = await new HttpClient().GetStringAsync(urlJsonFile);
        books = JsonSerializer.Deserialize<IEnumerable<Book>>(getJsonFile)!;        
        return books.OrderBy(b => b.Preco).ToList();
    }

    /// <summary>
    /// - Retorna uma lista de todos os livros em ordem DECRESCENTE tendo o valor do campo "preço" usado como referência/parâmetro
    /// </summary>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("/api/books/price/desc")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IEnumerable<Book>> GetBooksOrderByPriceDesc()
    {        
        var getJsonFile = await new HttpClient().GetStringAsync(urlJsonFile);
        books = JsonSerializer.Deserialize<IEnumerable<Book>>(getJsonFile)!;
        return books.OrderByDescending(b => b.Preco).ToList();            
    }

    /// <summary>
    /// - Retorna uma lista de todos os livros de acordo com o "nome do autor" passado como referência/parâmetro
    /// </summary>
    /// <param name="author">Nome do autor do livro</param>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("/api/books/author")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IEnumerable<Book>> GetBooksByAuthorName(string author)
    {        
        var getJsonFile = await new HttpClient().GetStringAsync(urlJsonFile);
        books = JsonSerializer.Deserialize<IEnumerable<Book>>(getJsonFile)!;
        return books.Where(b => b.Especificacoes!.Autor!.Contains(author, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    /// <summary>
    /// - Retorna uma lista de todos os livros de acordo com o "nome do livro" passado como referência/parâmetro
    /// </summary>
    /// <param name="name">Nome do livro</param>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("/api/books/name")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IEnumerable<Book>> GetBooksByBookName(string name)
    {        
        var getJsonFile = await new HttpClient().GetStringAsync(urlJsonFile);
        books = JsonSerializer.Deserialize<IEnumerable<Book>>(getJsonFile)!;
        return books.Where(b => b.Nome!.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    /// <summary>
    /// - Retorna uma lista de todos os livros de acordo com o "gênero" passado como referência/parâmetro
    /// </summary>
    /// <param name="genre">Gênero do livro</param>
    /// <returns>Json</returns>
    /// <response code="200">Caso a consulta seja executada com sucesso</response>
    [HttpGet("/api/books/genre")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IEnumerable<Book>> GetBooksByGenre(string genre)
    {        
        var getJsonFile = await new HttpClient().GetStringAsync(urlJsonFile);
        books = JsonSerializer.Deserialize<IEnumerable<Book>>(getJsonFile)!;
        return books.Where(b => b.Especificacoes!.Genres!.ToString()!.Contains(genre, StringComparison.OrdinalIgnoreCase)).ToList();
    } 
}
