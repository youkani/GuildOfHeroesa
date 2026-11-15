public class Film
{
    public string Name;
    public int Data;
    public string Genre;
    public double Rating;
    public string Status;

    public Film(string name, int data, string genre, double rating)
    {
        Name = name;
        Data = data;
        Genre = genre;
        Rating = rating;
        Status = "Доступен";
    }

    public void UpdateRating(double newRating)
    {
        if (newRating < 0 || newRating > 10)
        {
            return;
        }

        Rating = newRating;
    }

    public void ChangeStatus(string newStatus)
    {
        if (newStatus.Length == 0)
        {
            return;
        }
        Status = newStatus;
    }

    public bool IsTopRated()
    {
        return Rating >= 8.0;
    }
}