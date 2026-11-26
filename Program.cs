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
board.AddQuest(new Quest(101, "Вернуть поплавок", 100, 30));
board.TryAssign(101, "Сергей");
board.TryComplete(101);

board.AddQuest(new Quest(102, "Проверить нижнюю площадку", 100, 10));
board.AddQuest(new Quest(103, "Снять мерки для насоса больницы", 100, 20));
board.AddQuest(new Quest(104, "Обследовать ответвление", 100, 15));

Console.WriteLine($"Сергей на №102: {board.TryAssign(102, "Сергей")}");
Console.WriteLine($"Сергей на №103: {board.TryAssign(103, "Сергей")}");
Console.WriteLine($"Отмена №102: {board.TryCancel(102)}");
Console.WriteLine($"Сергей на №103: {board.TryAssign(103, "Сергей")}");
Console.WriteLine($"Завершение №103: {board.TryComplete(103)}");
Console.WriteLine($"Ярослав на №104: {board.TryAssign(104, "Ярослав")}");
Console.WriteLine($"Удалить Сергея: {board.TryRemoveMember("Сергей")}");

Console.WriteLine();
List<Quest> quests = board.GetQuests();
foreach (Quest quest in quests) {
    Console.WriteLine(quest.GetInfo());
}

Console.WriteLine($"Открыто: {board.CountByStatus(QuestStatus.Open)}, " +
                  $"назначено: {board.CountByStatus(QuestStatus.Assigned)}, " +
                  $"выполнено: {board.CountByStatus(QuestStatus.Completed)}, " +
                  $"отменено: {board.CountByStatus(QuestStatus.Cancelled)}");

Quest? yaroslavQuest = board.FindActiveQuest("Ярослав");
if (yaroslavQuest != null) {
    Console.WriteLine($"Ярослав сейчас: №{yaroslavQuest.Id} «{yaroslavQuest.Title}»");
} else {
    Console.WriteLine("Ярослав сейчас: свободен");
}

Quest? sergeyQuest = board.FindActiveQuest("Сергей");
if (sergeyQuest != null) {
    Console.WriteLine($"Сергей сейчас: №{sergeyQuest.Id} «{sergeyQuest.Title}»");
} else {
    Console.WriteLine("Сергей сейчас: свободен");
}

Console.WriteLine();
Console.WriteLine(sergey.GetInfo());

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
// foreach (Film i in films) {
//     Console.WriteLine(i.Info());
// }

// Console.WriteLine($"Фильмов с рейтингом от 8.5: {collection.CountTopRated(8.5)}");

// Console.WriteLine($"Удалён фильм Матрица: {collection.RemoveFilm("Матрица")}");

// Viewing show = new Viewing(01, 8.0);

// Film? goodFilm = collection.FindFilmByName("интерстеллар");
// if (goodFilm != null) {
//     Console.WriteLine($"Успешный старт: {show.TryStart(goodFilm)}");
// }

// Film? lowRated = collection.FindFilmByName("человек-паук: новый день");
// if (lowRated != null) {
//     Console.WriteLine($"Отказ: {show.TryStart(lowRated)}");
// }

// Console.WriteLine($"Успешное завершение: {show.TryFinish()}");
// Console.WriteLine($"отказ от повтора: {show.TryFinish()}");

// Film? checkInCollection = collection.FindFilmByName("Интерстеллар");
// if (checkInCollection != null)
// {
//     Console.WriteLine($"Статус фильма интерстеллар после сеанса: {checkInCollection.Status}");
// }