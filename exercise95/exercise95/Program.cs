using exercise94.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        List<Car> countries = JsonSerializer.Deserialize<List<Car>>(response)!;
        foreach (Car car in countries)
        {
            Console.WriteLine(car.DetailedDescription);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Error: {e.Message}");
    }
}
