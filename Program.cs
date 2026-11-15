Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("Александр", 150);

Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());

//Самостоятельная работа

// Film interstellar = new Film("Интерстеллар", 2014, "Научная фантастика", 8.7);
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
// Console.WriteLine($"<<Фильм {spiderMan.Name}>>");
// Console.WriteLine($"{spiderMan.Data} года создания");
// Console.WriteLine($"Жанр: {spiderMan.Genre}");
// Console.WriteLine($"Оценка: {spiderMan.Rating}/10");
// Console.WriteLine($"доступность: {spiderMan.Status}");
// Console.WriteLine($"В топе (рейтинг >= 8.0): {spiderMan.IsTopRated()}");

// Console.WriteLine();
// Console.WriteLine($"Фильм: {interstellar.Name}. Изначальный рейтинг: {interstellar.Rating}");

// interstellar.UpdateRating(9.2);
// Console.WriteLine($"Рейтинг после обновления: {interstellar.Rating}");

// interstellar.UpdateRating(15.0);
// Console.WriteLine($"Рейтинг после попытки поставить 15.0: {interstellar.Rating}");

//практическая 2. Найдите и исправьте две ошибки
// yaroslav.TakeDamage(20);
//"yaroslav.TakeDamage();" В скобках при вызове метода нужно написать аргумент.

// Console.WriteLine(yaroslav.GetInfo());
//"yaroslav.GetInfo();" Метод возвращает строку с данными но не выводит её.