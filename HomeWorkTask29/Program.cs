// Напишите программу, которая задаёт
// массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.
// Например
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// Первое решение как на уроке.

// int[] array = new int[8];

// FillArray(array);
// PrintArray(array);

// void FillArray(int[] arr)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(0, 100);
//     }
// }

// void PrintArray(int[] arr1)
// {
//     int count = arr1.Length;
//     int index = 0;
//     Console.Write($"Массив -> [");
//     while (index < count)
//     {
//         Console.Write(arr1[index]);
//         index++;
//         if (index < count)
//         {
//             Console.Write(", ");
//         }
//     }
//     Console.Write("]");
// }


//Второе решение без магических чисел.


int[] array = CreateArray(8);
PrintArray(array);

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        int sizeA = 0;
        int sizeB = 100;
        arr[i] = rnd.Next(sizeA, sizeB);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int index = 0;
    Console.Write($"Массив {arr.Length} -> [");
    while (index < count)
    {
        Console.Write(arr[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}