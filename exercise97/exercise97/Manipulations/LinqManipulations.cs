using exercise97.Models;

namespace exercise97.Manipulations;

internal class LinqManipulations
{
    public static List<string> GetAllMusicGenres(List<MusicDeserialize> musics)
    {
        List<string> musicGenres = musics.Select(music => music.Genre).Distinct().ToList()!;

        Console.WriteLine("Musical Genres:");
        foreach (string genre in musicGenres)
        {
            Console.WriteLine($" - {genre}");
        }
        Console.WriteLine($"Total: {musicGenres.Count} different musical genres\n");
        return musicGenres;
    }

    public static List<string> GetAllArtistsSorted(List<MusicDeserialize> musics)
    {
        List<string> artistsOrdained = musics.Select(music => music.Artist).OrderBy(artist => artist).Distinct().ToList()!;

        Console.WriteLine("Ordered artists:");
        foreach (string artist in artistsOrdained)
        {
            Console.WriteLine($" - {artist}");
        }
        Console.WriteLine($"Total: {artistsOrdained.Count} distinct artists\n");
        return artistsOrdained;
    }

    public static List<string> GetArtistsByMusicGenre(List<MusicDeserialize> musics, string musicGenre)
    {
        List<string> artistsByMusicGenre = musics.Where(music => music.Genre == musicGenre).Select(music => music.Artist).Distinct().ToList()!;

        Console.WriteLine($"Artists of the musical genre {musicGenre}");
        foreach (string artist in artistsByMusicGenre)
        {
            Console.WriteLine($" - {artist}");
        }
        Console.WriteLine($"Total: {artistsByMusicGenre.Count} artists for the {musicGenre} musical genre\n");
        return artistsByMusicGenre;
    }

    public static List<MusicDeserialize> GetMusicsByArtist(List<MusicDeserialize> musics, string artist)
    {
        List<MusicDeserialize> musicsByArtist = musics.Where(music => music.Artist!.Equals(artist)).ToList()!;

        Console.WriteLine($"Songs by the artist {artist}");
        foreach (MusicDeserialize music in musicsByArtist)
        {
            Console.WriteLine($" - {music.Song}");
        }
        Console.WriteLine($"Total: {musicsByArtist.Count} songs for the artist {artist}\n");
        return musicsByArtist;
    }

    public static List<MusicDeserialize> GetMusicsByYear(List<MusicDeserialize> musics, int year)
    {
        List<MusicDeserialize> musicsByYear = musics.Where(music => music.Year!.Equals(Convert.ToString(year))).ToList()!;

        Console.WriteLine($"Songs of the year {year}");
        foreach (MusicDeserialize music in musicsByYear)
        {
            Console.WriteLine($" - {music.Song}");
        }
        Console.WriteLine($"Total: {musicsByYear.Count} songs of the year {year}\n");
        return musicsByYear;
    }

    public static List<MusicDeserialize> GetMusicsByTone(List<MusicDeserialize> musics, string tone)
    {
        List<MusicDeserialize> musicsByTone = musics.Where(music => music.Tone.Equals(tone)).ToList();

        Console.WriteLine($"Songs in the key of {tone}");
        foreach (MusicDeserialize music in musicsByTone)
        {
            Console.WriteLine($" - {music.Song}");
        }
        Console.WriteLine($"Total: {musicsByTone.Count} songs in the key of {tone}\n");
        return musicsByTone;
    }
}
