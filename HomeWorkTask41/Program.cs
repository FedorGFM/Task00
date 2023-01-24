// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Например
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



// Первое решение оно проще, но вывод не такой как в примере


Console.Write("Введите количество чисел: ");               
int m = Convert.ToInt32(Console.ReadLine());

int[] arrNumbers = new int[m];
SizeNumbers(m);

int res = PositiveNumbers(arrNumbers);
Console.WriteLine($"Пользователь ввел {res} чисела, которые больше 0.");

void SizeNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arrNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int PositiveNumbers(int[] arrNumbers)
{
    int count = 0;
    for (int i = 0; i < arrNumbers.Length; i++)
    {
        if (arrNumbers[i] > 0)
            count++;
    }
    return count;
}




//Второе решение вывод как в примере


// Console.Write("Введите количество чисел: ");          
// int m = Convert.ToInt32(Console.ReadLine());

// int[] userArray = CreateArray(m);
// PrintArray(userArray);
// int positiveNumbers = PositiveNumbers(userArray);
// Console.Write($" -> Пользователь ввел {positiveNumbers} чисела, которые больше 0.");


// int[] CreateArray(int count)
// {
//     int[] array = new int[count];
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"Введите {i + 1} число: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("В мфссиве [");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(i < arr.Length - 1) Console.Write(arr[i] + ", ");
//         else Console.Write(arr[i]);
//     }
//     Console.Write("]");
// }

// int PositiveNumbers(int[] arrNumbers)
// {
//     int count = 0;
//     for (int i = 0; i < arrNumbers.Length; i++)
//     {
//         if (arrNumbers[i] > 0)
//             count++;
//     }
//     return count;
// }
