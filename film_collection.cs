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
            if (i.Rating >= minRating) {
                count += 1;
            }
        }
        return count;
    }
}
