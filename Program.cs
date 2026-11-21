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
List<Hero> members = guild.GetMembers();

Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.MemberCount}");

if (members.Count > 0) {
    Console.WriteLine($"Первый: {members[0].Name}");
    Console.WriteLine($"Последний: {members[members.Count - 1].Name}");
}

Console.WriteLine();
foreach (Hero hero in members)
{
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}

Hero? found = guild.FindHeroByName(" аРтЁм ");
if (found != null) {
    Console.WriteLine($"Найден по запросу « аРтЁм »: {found.Name}");
} else {
    Console.WriteLine("По запросу « аРтЁм » никого нет.");
}
Console.WriteLine($"Повтор Александра принят: {guild.AddHero(alexander)}");
Console.WriteLine($"Удалён отсутствующий: {guild.RemoveHero("Борис")}");
Console.WriteLine($"Участников после проверок: {guild.MemberCount}");

Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {guild.CountHealthy(120)}");

Hero? strongest = guild.FindStrongest();
if (strongest != null) {
    Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
}

//Самостоятельная работа

Film interstellar = new Film("Интерстеллар", 2014, "Научная фантастика", 8.7);
Film shutterIsland = new Film("Остров проклятых", 2009, "Триллер", 8.6);
Film spiderMan = new Film("Человек-паук: Новый день", 2026, "Приключения", 7.9);

FilmCollection collection = new FilmCollection("Коллекция фильмов");
collection.Films.Add(interstellar);
collection.Films.Add(shutterIsland);
collection.Films.Add(spiderMan);

Console.WriteLine($"\nКоличество фильмов: {collection.Films.Count}");
if (collection.Films.Count > 0) {
    Console.WriteLine($"Первый: {collection.Films[0].Name}");
    Console.WriteLine($"Последний: {collection.Films[collection.Films.Count - 1].Name}");
}

Film Matrix = new Film("Матрица", 1999, "Фантастика", 8.7);
collection.Films.Add(Matrix);

Console.WriteLine("\nСписок фильмов:");
foreach (Film film in collection.Films) {
    Console.WriteLine(film.Info());
}

int FilmsCount = 0;
foreach (Film film in collection.Films) {
    if (film.Rating >= 8.5) {
        FilmsCount += 1;
    }
}
Console.WriteLine($"\nФильмов с рейтингом от 8.5: {FilmsCount}");

interstellar.ChangeStatus("Просмотрен");
interstellar.ChangeStatus("");

Console.WriteLine($"\nИзменение состояния фильма интерстеллар: {collection.Films[0].Status}");