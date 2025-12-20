using exercise96.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        List<Book> books = JsonSerializer.Deserialize<List<Book>>(response)!;
        foreach (Book book in books)
        {
            Console.WriteLine(book.DetailedDescription);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Error: {e.Message}");
    }
}
