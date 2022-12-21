// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели"); // выводит текст в терминае
string a = Console.ReadLine(); // записывает в number число введенное пользователем в терминал и переводит в int32
if (a == "1")Console.WriteLine("Понедельник");

else if (a == "2")Console.WriteLine("Вторник");

else if (a == "3")Console.WriteLine("Среда");

else if (a == "4")Console.WriteLine("Четверг");

else if (a == "5")Console.WriteLine("Пятница");

else if (a == "6")Console.WriteLine("Суббота");

else if (a == "7")Console.WriteLine("Воскресенье");

else
{
    Console.WriteLine("Неверно ввели данные");
}
