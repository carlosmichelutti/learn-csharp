using exercise94.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        List<Country> countries = JsonSerializer.Deserialize<List<Country>>(response)!;
        foreach(Country country in countries)
        {
            Console.WriteLine(country.DetailedDescription);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Error: {e.Message}");
    }
}
