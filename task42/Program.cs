// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// // Пользователь вводит число через терминал
// Console.Write("Введите число: ");
// int size = Convert.ToInt32(Console.ReadLine());  

// string res = ReversDecToBin(size);     //число в () мы вводим вручную то которое нам нужно
// Console.WriteLine($"{size} из десятичнойб в двоичную систему счисления -> {res}");

// string ReversDecToBin(int num)
// {
//     string result = string.Empty;
//     while (num > 0)
//     {
//         result = num % 2 + result;    // Если поменять местами num % 2 и result то результат развернется например: 1101 будет 1011
//         num = num / 2;
//     }
//     return result;
// }

// Пользователь вводит число в строке
string res = ConvertDecToBin(13);     //число в () мы вводим вручную то которое нам нужно
Console.WriteLine(res);

string ConvertDecToBin(int num)
{
string result = string.Empty;
while (num > 0)
{
result = num % 2 + result;
num = num / 2;
}
return result;
}