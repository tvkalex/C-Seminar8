// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

Console.Clear();
Console.WriteLine("Введите размер массива m x n:");
int m = inputNumber("m = ");
int n = inputNumber("n = ");
int[,] array = new int[m, n];
int[,] secondArray = new int[m, n];
FillArray(array);
Console.WriteLine("\nИсходный массив 1:");
PrintArray(array);
FillArray(secondArray);
Console.WriteLine("\nИсходный массив 2:");
PrintArray(secondArray);

int[,] resultArray = new int[m, n];
if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine("\nНельзя перемножить!\n");
    Console.WriteLine();
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}
Console.WriteLine($"\nРезультирующий массив:");
PrintArray(resultArray);
Console.WriteLine();

int inputNumber(string message)
{
    int number;
    string text;
    while (true)
    {
        Console.Write(message);
        text = Console.ReadLine()!;
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
