// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArrayRndDouble(7, 0, 2);
PrintArrayDouble(array);
double maxArr = MaxArray(array);
Console.WriteLine($"Max = {maxArr}");
double minArr = MinArray(array);
Console.WriteLine($"Min = {minArr}");
Console.WriteLine($"Разницу между максимальным и минимальным элементом массива = {Math.Round(maxArr - minArr, 1)}");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

double MaxArray(double[] arr)
{
    double maxArr = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxArr)
            maxArr = arr[i];
    }
    return maxArr;
}

double MinArray(double[] arr)
{
    double minArr = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minArr)
            minArr = arr[i];
    }
    return minArr;
}
