string[] array = { "Апельсин", "Грейпфрут", "Лимон", "Лайм", "Мандарин" };
int count = array.Count(s => s.Length > 6);

Console.WriteLine(count);