using exercise97.Manipulations;
using exercise97.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        List<MusicDeserialize> musics = JsonSerializer.Deserialize<List<MusicDeserialize>>(response)!;
        List<string> musicGenres = LinqManipulations.GetAllMusicGenres(musics);
        List<string> artistsOrdained = LinqManipulations.GetAllArtistsSorted(musics);
        List<string> artistsByMusicGenre = LinqManipulations.GetArtistsByMusicGenre(musics, "rock");
        List<MusicDeserialize> musicsByArtist = LinqManipulations.GetMusicsByArtist(musics, "Eminem");
        List<MusicDeserialize> musicsByYear = LinqManipulations.GetMusicsByYear(musics, 2020);
        List<MusicDeserialize> musicsByTone = LinqManipulations.GetMusicsByTone(musics, "C#");

        MusicSerialize musicSerialize = new MusicSerialize();
        musicSerialize.AddMusic(musicsByArtist);
        musicSerialize.SerializeDataToJson();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
