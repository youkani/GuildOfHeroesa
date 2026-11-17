//Probe.Run();

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("Александр", 150);
Hero sergey = new Hero("Сергей", 110);

alexander.TakeDamage(10);
alexander.Heal(10);

Guild guild = new Guild("Гильдия героев");
guild.Heroes.Add(yaroslav);
guild.Heroes.Add(anastasia);
guild.Heroes.Add(artem);
guild.Heroes.Add(alexander);
guild.Heroes.Add(sergey);
Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.Heroes.Count}");

if (guild.Heroes.Count > 0) {
    Console.WriteLine($"Первый: {guild.Heroes[0].Name}");
    Console.WriteLine($"Последний: {guild.Heroes[guild.Heroes.Count - 1].Name}");
}

Console.WriteLine();
foreach (Hero hero in guild.Heroes) {
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}

//Самостоятельная работа

// Film interstellar = new Film("Интерстеллар", 2014, "Научная фантастика", 8.7);
// Film shutterIsland = new Film("Остров проклятых", 2009, "Триллер", 8.6);
// Film spiderMan = new Film("Человек-паук: Новый день", 2026, "Приключения", 7.9);

// interstellar.ChangeStatus("Просмотрен");
// interstellar.ChangeStatus("");

// Console.WriteLine();
// Console.WriteLine($"<<Фильм {interstellar.Name}>>");
// Console.WriteLine($"{interstellar.Data} года создания");
// Console.WriteLine($"Жанр: {interstellar.Genre}");
// Console.WriteLine($"Оценка: {interstellar.Rating}/10");
// Console.WriteLine($"доступность: {interstellar.Status}");
// Console.WriteLine($"В топе (рейтинг >= 8.0): {interstellar.IsTopRated()}");

// Console.WriteLine();
// Console.WriteLine($"<<Фильм {shutterIsland.Name}>>");
// Console.WriteLine($"{shutterIsland.Data} года создания");
// Console.WriteLine($"Жанр: {shutterIsland.Genre}");
// Console.WriteLine($"Оценка: {shutterIsland.Rating}/10");
// Console.WriteLine($"доступность: {shutterIsland.Status}");
// Console.WriteLine($"В топе (рейтинг >= 8.0): {shutterIsland.IsTopRated()}");

// Console.WriteLine();
// Console.WriteLine($"<<Фильм {spiderMan.Name}>>");
// Console.WriteLine($"{spiderMan.Data} года создания");
// Console.WriteLine($"Жанр: {spiderMan.Genre}");
// Console.WriteLine($"Оценка: {spiderMan.Rating}/10");
// Console.WriteLine($"доступность: {spiderMan.Status}");
// Console.WriteLine($"В топе (рейтинг >= 8.0): {spiderMan.IsTopRated()}");