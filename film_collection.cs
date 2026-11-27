public class FilmCollection {
    private List<Film> _films = new List<Film>();
    private List<Viewing> _viewings = new List<Viewing>();

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
            if (i.Rating >= minRating) {
                count += 1;
            }
        }
        return count;
    }
    
    public bool AddViewing(Viewing viewing) {
        if (viewing.Status != ViewingStatus.Open) {
            return false;
        }
        _viewings.Add(viewing);
        return true;
    }

    public bool IsFilmBusy(Film film) {
        foreach (Viewing v in _viewings) {
            if (v.Status == ViewingStatus.Active && v.SelectedFilm == film) {
                return true;
            }
        }
        return false;
    }

    public bool TryStartViewing(Viewing viewing, string filmName) {
        Film? film = FindFilmByName(filmName);
        if (film == null) {
            return false;
        }
        if (IsFilmBusy(film)) {
            return false;
        }
        return viewing.TryStart(film);
    }
}

public class Viewing {
    public int Id { get; private set; }
    public double MinRating { get; private set; }
    public Film? SelectedFilm { get; private set; }
    public ViewingStatus Status { get; private set; }

    public Viewing(int id, double minRating) {
        Id = id;
        if (minRating < 0) {
            MinRating = 0;
        } else {
            MinRating = minRating;
        }
        SelectedFilm = null;
        Status = ViewingStatus.Open;
    }

    public bool TryStart(Film film) {
        if (Status != ViewingStatus.Open) {
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
        Status = ViewingStatus.Active;
        return true;
    }

    public bool TryFinish() {
        if (Status != ViewingStatus.Active) {
            return false;
        }
        Film? film = SelectedFilm;
        if (film == null) {
            return false;
        }
        film.ChangeStatus("Просмотрен");
        Status = ViewingStatus.Completed;
        return true;
    }
    
    public bool TryCancel() {
        if (Status != ViewingStatus.Open && Status != ViewingStatus.Active) {
            return false;
        }
        Status = ViewingStatus.Cancelled;
        return true;
    }
}

public enum ViewingStatus
{
    Open,
    Active,
    Completed,
    Cancelled
}
