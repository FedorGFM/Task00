// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = CreateArrayRndInt(6, -10, 25);
PrintArray(array);

int sumNechet = SumNechetNumArr(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sumNechet}");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}


int SumNechetNumArr(int[] arr)
{
    int sumNechet = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i % 2 != 0)
            sumNechet += arr[i];
    }
    return sumNechet;
}