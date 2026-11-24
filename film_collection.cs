public class FilmCollection {
    private List<Film> _films = new List<Film>();
    public string Name { get; private set; }

    public int FilmCount {
        get { return _films.Count; }
    }
    public FilmCollection(string name) {
        Name = name;
    }

    public bool AddFilm(Film film) {
        if (FindFilmByName(film.Name) != null) {
            return false;
        }
        _films.Add(film);
        return true;
    }

    public Film? FindFilmByName(string name) {
        if (string.IsNullOrWhiteSpace(name)) {
            return null;
        }
        string searchName = name.Trim();

        foreach (Film i in _films) {
            if (string.Equals(i.Name.Trim(), searchName, StringComparison.OrdinalIgnoreCase)) {
                return i;
            }
        }
        return null;
    }

    public bool RemoveFilm(string name) {
        Film? film = FindFilmByName(name);
        if (film == null) {
            return false;
        }
        return _films.Remove(film);
    }

    public List<Film> GetFilms() {
        List<Film> result = new List<Film>();
        foreach (Film i in _films) {
            result.Add(i);
        }
        return result;
    }

    public int CountTopRated(double minRating) {
        int count = 0;
        foreach (Film i in _films) {
            if (i.Rating >= minRating)
            {
                count += 1;
            }
        }
        return count;
    }
}

public class Viewing {
    public int Id { get; private set; }
    public double MinRating { get; private set; }
    public Film? SelectedFilm { get; private set; }
    public bool IsCompleted { get; private set; }

    public Viewing(int id, double minRating) {
        Id = id;
        if (minRating < 0) {
            MinRating = 0;
        } else {
            MinRating = minRating;
        }
        SelectedFilm = null;
        IsCompleted = false;
    }

    public bool TryStart(Film film) {
        if (IsCompleted) {
            return false;
        }
        if (SelectedFilm != null) {
            return false;
        }
        if (film.Status != "Доступен") {
            return false;
        }
        if (film.Rating < MinRating) {
            return false;
        }
        SelectedFilm = film;
        return true;
    }

    public bool TryFinish() {
        if (IsCompleted) {
            return false;
        }
        Film? film = SelectedFilm;
        if (film == null) {
            return false;
        }
        film.ChangeStatus("Просмотрен");
        IsCompleted = true;
        return true;
    }
}
