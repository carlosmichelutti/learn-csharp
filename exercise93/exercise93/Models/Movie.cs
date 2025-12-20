using System.Text.Json.Serialization;

namespace exercise93.Models;

internal class Movie
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("rank")]
    public string? Rank { get; set; }

    [JsonPropertyName("fullTitle")]
    public string? Title { get; set; }

    [JsonPropertyName("imDbRating")]
    public string? Rating { get; set; }

    public string DetailedDescription => $"Title {Title} - Rank {Rank} - Rating {Rating}";
}
