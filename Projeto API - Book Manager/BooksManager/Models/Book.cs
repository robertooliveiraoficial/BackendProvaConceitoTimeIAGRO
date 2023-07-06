using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BooksManager.Models;

public class Book
{
    [Key]
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [Required]
    [JsonPropertyName("name")]
    public string? Nome { get; set; }

    [JsonPropertyName("price")]
    public float Preco { get; set; }

    [JsonPropertyName("specifications")]
    public Specifications? Especificacoes { get; set; }

    [JsonPropertyName("freight")]
    public float Frete => (float)(Preco * 0.2);    
}
