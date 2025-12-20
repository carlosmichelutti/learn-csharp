using System.Text.Json;

namespace exercise97.Models;

internal class MusicSerialize
{
    public List<MusicDeserialize> FavoriteSongs { get; }

    public MusicSerialize()
    {
        FavoriteSongs = new List<MusicDeserialize>();
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
        });

        string fileName = $"favorite_songs.json";
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", fileName);
        File.WriteAllText(path, json);
    }
}
