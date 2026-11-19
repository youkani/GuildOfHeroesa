public class Film {
    public string Name;
    public int Data;
    public string Genre;
    public double Rating { get; private set; }
    public string Status;

    public Film(string name, int data, string genre, double rating) {
        Name = name;
        Data = data;
        Genre = genre;
        Rating = rating;
        Status = "Доступен";

        if (rating < 0) {
            Rating = 0;
        } else if (rating > 10) {
            Rating = 10;
        } else {
            Rating = rating;
        }
    }

    public void UpdateRating(double newRating) {
        if (newRating < 0 || newRating > 10) {
            return;
        }
        Rating = newRating;
    }

    public void ChangeStatus(string newStatus) {
        if (newStatus.Length == 0) {
            return;
        }
        Status = newStatus;
    }

    public bool IsTopRated() {
        return Rating >= 8.0;
    }

    public string Info() {
        return $"<<< {Name} ({Data}) >>>\n" +
               $"Жанр: {Genre}\n" +
               $"Рейтинг: {Rating}\n" +
               $"Статус: {Status}\n";
    }
}

public class FilmCollection {
    public string Name { get; private set; }
    public List<Film> Films { get; private set; } = new List<Film>();
    public FilmCollection(string name) {
        Name = name;
    }
}
