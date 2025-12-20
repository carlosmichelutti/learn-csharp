using System.Text.Encodings.Web;
using System.Text.Json;

namespace exercise97.Models;

internal class MusicSerialize
{
    public List<MusicDeserialize> FavoriteSongs { get; }
    JsonSerializerOptions Options;

    public MusicSerialize()
    {
        FavoriteSongs = new List<MusicDeserialize>();
        Options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
    }

    public void AddMusic(List<MusicDeserialize> musics)
    {
        foreach (MusicDeserialize music in musics)
        {
            FavoriteSongs.Add(music);
        }
    }

    public void AddMusic(MusicDeserialize music)
    {
        FavoriteSongs.Add(music);
    }

    public void SerializeDataToJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            musics = FavoriteSongs
        }, Options);

        string fileName = $"favorite_songs.json";
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", fileName);
        File.WriteAllText(path, json);
    }
}
