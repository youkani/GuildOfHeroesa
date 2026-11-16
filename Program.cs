Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("Александр", 150);

alexander.TakeDamage(10);
alexander.Heal(10);

Console.WriteLine(">>> Участники готовы <<<");
Console.WriteLine();
Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());
Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");

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

//проверки самостоятельной работы

// interstellar.UpdateRating(15.0);
// Console.WriteLine($"Фильм: {interstellar.Name}. Проверка  рейтинга 15.0: {interstellar.Rating}");
// interstellar.UpdateRating(10.0);
// Console.WriteLine($"Проверка  рейтинга 10.0: {interstellar.Rating}");
// interstellar.UpdateRating(-5.0);
// Console.WriteLine($"Проверка  рейтинга -5.0: {interstellar.Rating}");
// interstellar.Rating = 100;