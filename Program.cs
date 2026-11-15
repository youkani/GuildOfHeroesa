Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
//A
// Hero margarita = new Hero("Маргарита", 80);
// margarita.TakeDamage(30);
// margarita.Heal(15);
// margarita.GainExperience(50);
// Console.WriteLine($"Маргарита жива: {margarita.IsAlive()}");
// Console.WriteLine(margarita.GetInfo());

//Б
// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 100);
// yaroslav.TakeDamage(40);
// anastasia.TakeDamage(10);
// Console.WriteLine($"Ярослав: {yaroslav.Health}");
// Console.WriteLine($"Анастасия: {anastasia.Health}");

Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");
yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);
Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");
artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");

yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");

bool yaroslavAlive = yaroslav.IsAlive();
Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
Console.WriteLine($"Артём жив: {artem.IsAlive()}");

if (yaroslavAlive)
{
    Console.WriteLine("Ярослав может продолжать приключение.");
}
else
{
    Console.WriteLine("Ярослав больше не может сражаться.");
}

string info = yaroslav.GetInfo();
Console.WriteLine("Строка получена. Сейчас выведем её:");
Console.WriteLine(info);

Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());

//практическая 2. Самостоятельная работа

Film interstellar = new Film("Интерстеллар", 2014, "Научная фантастика", 8.7);
Film spiderMan = new Film("Человек-паук: Новый день", 2026, "Приключения", 7.9);

interstellar.ChangeStatus("Просмотрен");
interstellar.ChangeStatus("");

Console.WriteLine();
Console.WriteLine($"<<Фильм {interstellar.Name}>>");
Console.WriteLine($"{interstellar.Data} года создания");
Console.WriteLine($"Жанр: {interstellar.Genre}");
Console.WriteLine($"Оценка: {interstellar.Rating}/10");
Console.WriteLine($"доступность: {interstellar.Status}");
Console.WriteLine($"В топе (рейтинг >= 8.0): {interstellar.IsTopRated()}");

Console.WriteLine();
Console.WriteLine($"<<Фильм {spiderMan.Name}>>");
Console.WriteLine($"{spiderMan.Data} года создания");
Console.WriteLine($"Жанр: {spiderMan.Genre}");
Console.WriteLine($"Оценка: {spiderMan.Rating}/10");
Console.WriteLine($"доступность: {spiderMan.Status}");
Console.WriteLine($"В топе (рейтинг >= 8.0): {spiderMan.IsTopRated()}");

Console.WriteLine();
Console.WriteLine($"Фильм: {interstellar.Name}. Изначальный рейтинг: {interstellar.Rating}");

interstellar.UpdateRating(9.2);
Console.WriteLine($"Рейтинг после обновления: {interstellar.Rating}");

interstellar.UpdateRating(15.0);
Console.WriteLine($"Рейтинг после попытки поставить 15.0: {interstellar.Rating}");

//практическая 2. Найдите и исправьте две ошибки
// yaroslav.TakeDamage(20);
//"yaroslav.TakeDamage();" В скобках при вызове метода нужно написать аргумент.

// Console.WriteLine(yaroslav.GetInfo());
//"yaroslav.GetInfo();" Метод возвращает строку с данными но не выводит её.

//практическая 1. Самостоятельная работа
// Film interstellar = new Film("Интерстеллар", 2014, "Научная фантастика", 8.7);
// Film shutterIsland = new Film("Остров проклятых", 2009, "Триллер", 8.6);
// Film spiderMan = new Film("Человек-паук: Новый день", 2026, "Приключения", 7.9);

// Console.WriteLine($"<<Фильм {interstellar.Name}>>");
// Console.WriteLine($"{interstellar.Data} года создания");
// Console.WriteLine($"Жанр: {interstellar.Genre}");
// Console.WriteLine($"Оценка: {interstellar.Rating}/10");
// Console.WriteLine($"доступность: {interstellar.Status}");

// Console.WriteLine();

// Console.WriteLine($"<<Фильм {shutterIsland.Name}>>");
// Console.WriteLine($"{shutterIsland.Data} года создания");
// Console.WriteLine($"Жанр: {shutterIsland.Genre}");
// Console.WriteLine($"Оценка: {shutterIsland.Rating}/10");
// Console.WriteLine($"доступность: {shutterIsland.Status}");

// Console.WriteLine();

// Console.WriteLine($"<<Фильм {spiderMan.Name}>>");
// Console.WriteLine($"{spiderMan.Data} года создания");
// Console.WriteLine($"Жанр: {spiderMan.Genre}");
// Console.WriteLine($"Оценка: {spiderMan.Rating}/10");
// Console.WriteLine($"доступность: {spiderMan.Status}");