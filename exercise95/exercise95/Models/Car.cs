using System.Text.Json.Serialization;

namespace exercise95.Models;

internal class Car
{
    [JsonPropertyName("marca")]
    public string? Brand { get; set; }

    [JsonPropertyName("modelo")]
    public string? Model { get; set; }

    [JsonPropertyName("ano")]
    public int? Year { get; set; }

    [JsonPropertyName("tipo")]
    public string? Type { get; set; }

    public string DetailedDescription => $"Brand: {Brand} - Model: {Model} - Year: {Year} - Type: {Type}";
}
