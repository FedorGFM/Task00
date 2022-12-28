// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");

string quarter = Console.ReadLine();
string result = QuarterCoordinates(quarter);

Console.WriteLine(result);

string QuarterCoordinates(string number)
{
    if(number == "1") return "Диапазон координат x > 0; y > 0";
    if(number == "2") return "Диапазон координат x < 0; y > 0";
    if(number == "3") return "Диапазон координат x < 0; y < 0";
    if(number == "4") return "Диапазон координат x > 0; y < 0";
    return "Некоректный номер четверти";
}