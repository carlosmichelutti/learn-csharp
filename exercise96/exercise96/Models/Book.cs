using System.Text.Json.Serialization;

namespace exercise96.Models;

internal class Book
{
    [JsonPropertyName("titulo")]
    public string? Title { get; set; }

    [JsonPropertyName("autor")]
    public string? Author { get; set; }

    [JsonPropertyName("ano_publicacao")]
    public int? YearPublication { get; set; }

    [JsonPropertyName("genero")]
    public string? Gender { get; set; }

    [JsonPropertyName("paginas")]
    public int? Pages { get; set; }

    public string DetailedDescription => $"Title: {Title} - Author: {Author} - Year of Publication: {YearPublication} - Gender: {Gender} - Quantity Pages: {Pages}";
}
