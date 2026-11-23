//Probe.Run();

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("Александр", 150);
Hero sergey = new Hero("Сергей", 110);

alexander.TakeDamage(10);
alexander.Heal(10);

Guild guild = new Guild("Гильдия героев");
guild.AddHero(yaroslav);
guild.AddHero(anastasia);
guild.AddHero(artem);
guild.AddHero(alexander);
guild.AddHero(sergey);

Console.WriteLine($">>> {guild.Name}: участников {guild.MemberCount} <<<");
Console.WriteLine();

QuestBoard board = new QuestBoard(guild);
Quest floatQuest = new Quest(101, "Вернуть поплавок", 100, 30);
Console.WriteLine($"Поручение добавлено: {board.AddQuest(floatQuest)}");
Console.WriteLine($">>> №{floatQuest.Id}: {floatQuest.Title} <<<");

Console.WriteLine($"Назначение Сергея: {board.TryAssign(101, " сЕрГеЙ ")}");
Hero? assigned = floatQuest.AssignedHero;
if (assigned != null) {
    Console.WriteLine($"Исполнитель: {assigned.Name}");
}
Console.WriteLine($"Опыт после назначения: {sergey.Experience}");

Console.WriteLine($"Завершение: {board.TryComplete(101)}");
Console.WriteLine($"Опыт после завершения: {sergey.Experience}");
Console.WriteLine($"Повторное завершение: {board.TryComplete(101)}");
Console.WriteLine($"Опыт после повтора: {sergey.Experience}");

//Самостоятельная работа

// Film interstellar = new Film("Интерстеллар", 2014, "Научная фантастика", 8.7);
// Film shutterIsland = new Film("Остров проклятых", 2009, "Триллер", 8.6);
// Film spiderMan = new Film("Человек-паук: Новый день", 2026, "Приключения", 7.9);
// Film Matrix = new Film("Матрица", 1999, "Фантастика", 8.7);

// FilmCollection collection = new FilmCollection("Коллекция фильмов");
// collection.AddFilm(interstellar);
// collection.AddFilm(shutterIsland);
// collection.AddFilm(spiderMan);
// collection.AddFilm(Matrix);
// List<Film> films = collection.GetFilms();

// Console.WriteLine($"\n<<< Самостоятельный проект >>>");
// Console.WriteLine($"Количество фильмов: {collection.FilmCount}");
// if (films.Count > 0) {
//     Console.WriteLine($"Первый: {films[0].Name}");
//     Console.WriteLine($"Последний: {films[films.Count - 1].Name}");
// }

// Console.WriteLine();
// foreach (Film i in films)
// {
//     Console.WriteLine(i.Info());
// }

// Console.WriteLine($"Фильмов с рейтингом от 8.5: {collection.CountTopRated(8.5)}");

// interstellar.ChangeStatus("Просмотрен");
// Console.WriteLine($"Изменение состояния фильма интерстеллар: {collection.GetFilms()[0].Status}");

// Film? foundFilm = collection.FindFilmByName("  остРов проклЯтЫх  ");
// Console.WriteLine($"Повтор фильма интерстеллар принят: {collection.AddFilm(interstellar)}");

// if (foundFilm != null) {
//     Console.WriteLine($"Найден фильм по запросу `  остРов проклЯтЫх  `: {foundFilm.Name}");
// } else {
//     Console.WriteLine("Фильм не найден.");
// }

// Console.WriteLine($"Удалён фильм Матрица: {collection.RemoveFilm("Матрица")}");
// Console.WriteLine($"Фильмов после проверок: {collection.FilmCount}");