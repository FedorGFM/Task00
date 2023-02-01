// *Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrix(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] > 99)
                    break;
                Console.Write($"{matrix[i, j, k], 4} ({i},{j},{k})");
                if (k == matrix.GetLength(2) - 1)
                {
                    Console.Write("");
                }
            }
            if (j == matrix.GetLength(1) - 1) Console.WriteLine();
        }
    }
}

int[,,] array3D = CreateMatrix(2, 2, 2, 10, 99);
PrintMatrix(array3D);



// Рандом метод

// Random rnd = new Random();
// int rows = rnd.Next(1, 4);
// int columns = rnd.Next(1, 4);
// int depth = rnd.Next(1, 4);

// int[,,] array3D = CreateMatrix(rows, columns, depth, 10, 99);
// PrintMatrix(array3D);


// Заполнение вручную

// Console.WriteLine("Введите неповторяющиеся двухзначные числа.");
// System.Console.Write("Строк в матрице: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Столбцов в матрице: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Глубина матрицы: ");
// int depth = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите минимальное двухзначное число: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите максимальное двухзначное число: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,,] array3D = CreateMatrix(rows, columns, depth, min, max);
// PrintMatrix(array3D);