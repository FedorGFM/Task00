// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}   ");
        }
        Console.WriteLine("]");
    }
}

int[,] ProductOfTwoMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] productMatrix = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixSecond.GetLength(1); j++)
        {
            for (int k = 0; k < matrixSecond.GetLength(0); k++)
            {
                productMatrix[i, j] += matrixFirst[i, k] * matrixSecond[k, j];
            }
        }
    }
    return productMatrix;
}


Random rnd = new Random();             // На рандоме очень долго ловить результат, так что проще через присвоение собственных чисел.
int rowsFirst = rnd.Next(1, 10);       // На рандоме тоже работает проверял.
int columnsFirst = rnd.Next(1, 10);;
int rowsSecond = rowsFirst;
int columnsSecond = columnsFirst;

// int rowsFirst = 1;
// int columnsFirst = 5;
// int rowsSecond = 5;
// int columnsSecond = 3;

if (columnsFirst == rowsSecond)
{
    int[,] arrayFirst2D = CreateMatrix(rowsFirst, columnsFirst, 0, 10);
    int[,] arraySecond2D = CreateMatrix(rowsSecond, columnsSecond, 0, 10);
    Console.WriteLine("Матрица 1.");
    PrintMatrix(arrayFirst2D);
    Console.WriteLine("Матрица 2.");
    PrintMatrix(arraySecond2D);

    int[,] productMatrix = ProductOfTwoMatrix(arrayFirst2D, arraySecond2D);
    Console.WriteLine("Произведение двух матриц.");
    PrintMatrix(productMatrix);
}

else if (columnsFirst != rowsSecond)
{
    Console.WriteLine();
    Console.WriteLine("Количество столбцов матрицы 1 не равно количеству строк матрицы 2, следовательно их нельзя перемножать.");
}