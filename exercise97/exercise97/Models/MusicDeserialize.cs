using System.Text.Json.Serialization;

namespace exercise97.Models;

internal class MusicDeserialize
{
    [JsonPropertyName("song")]
    public string? Song { get; set; }

    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("year")]
    public string? Year { get; set; }

    [JsonPropertyName("duration_ms")]
    public int? Duration { get; set; }

    [JsonPropertyName("genre")]
    public string? Genre { get; set; }
}
