// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int matrixRows = 4;
int matrixColumns = 4;
int matrixMinValue = 1;
int matrixMaxValue = 11;

int[,] matrixRnd = CreateMatrix(matrixRows, matrixColumns, matrixMinValue, matrixMaxValue);
PrintMatrix(matrixRnd);

if (matrixRows == matrixColumns)
{
    Console.WriteLine(String.Empty);
    ChangeRowColumnsMatrix(matrixRnd);   
    //int[,] newMatrix = ChangeRowColumnsMatrix(matrixRnd);  // Для первого варинта решения
    //PrintMatrix(newMatrix);
    PrintMatrix(matrixRnd);  // Для второго решения
}
else Console.WriteLine("Ошибк. Число строк и столбцов не равны.");

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4}   ");
        }
        Console.WriteLine("]");
    }
}


// Первый вариант решения

// int[,] ChangeRowColumnsMatrix(int[,] matrix)
// {
//     int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             newMatrix[i, j] = matrix[j, i];
//         }
//     }
//     return newMatrix;
// }


// Второй вариант решения

void ChangeRowColumnsMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}
