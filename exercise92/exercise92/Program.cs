using exercise92.Models;

List<Media> digitalMedias = new List<Media>
{
    new Image("landscape.jpg", "1920x1080"),
    new Video("movie.mp4", 120)
};

foreach (Media media in digitalMedias)
{
    media.ShowDetails();
}
