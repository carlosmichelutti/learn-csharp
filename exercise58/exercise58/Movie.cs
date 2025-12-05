public class Movie
{
    public string Title { get; set; }
    public int AgeClassification { get; set; }

    public Movie(string title, int ageClassification)
    {
        Title = title;
        AgeClassification = ageClassification;
    }

    public bool CanWatch(int userAge)
    {
        return userAge >= AgeClassification;
    }

    public void DisplayResult(int userAge)
    {
        if (CanWatch(userAge))
        {
            Console.WriteLine($"Users aged {userAge} and over can watch the movie {Title}.");
        }
        else
        {
            Console.WriteLine($"Users aged {userAge} and under cannot watch the movie {Title}.");
        }
    }
}
