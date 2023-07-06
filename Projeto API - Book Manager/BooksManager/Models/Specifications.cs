using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BooksManager.Models;

public class Specifications
{
    [JsonPropertyName("Originally published")]
    public string? PublicacaoOriginal { get; set; }

    [Required]
    [JsonPropertyName("Author")]
    public string? Autor { get; set; }

    [JsonPropertyName("Page count")]
    public int QuantidadeDePaginas { get; set; }

    [JsonPropertyName("Illustrator")]
    public object? Illustrator { get; set; }

    [Required]
    [JsonPropertyName("Genres")]
    public object? Genres { get; set; }
}