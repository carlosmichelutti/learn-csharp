using exercise93.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        List<Movie> movies = JsonSerializer.Deserialize<List<Movie>>(response)!;
        foreach(Movie movie in movies)
        {
            Console.WriteLine(movie.DetailedDescription);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Error: {e.Message}");
    }
}
