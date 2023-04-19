/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с
наименьшей суммой элементов: 1 строка*/


int[,] array = CreateArray();
Console.WriteLine("Изначальный массив:");
PrintArray(array);
SumRows(array);

void SumRows(int[,] array)
{
    int sumRows = 0;
    int minSum = 0;
    int minSumRow = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumRows = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRows += array[i, j];
        }
        if (i == 0) 
        {
            minSum = sumRows;
            minSumRow = 0;
        }
        else if (sumRows < minSum) 
        {
            minSum = sumRows;
            minSumRow = i;
        }       
    }

    Console.Write($"{minSumRow + 1} строка с наименьшей суммой элементов");
}

int [,] CreateArray ()
{
    int [,] Array = new int [4, 4];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = new Random().Next(1, 16);
        }
    }
    return Array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i,j]+" ");
        }
    Console.WriteLine();
    }
}