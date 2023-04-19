/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
int[,] arrayFirst = CreateArray();
int[,] arraySecond = CreateArray();
Console.WriteLine("Первый массив:");
PrintArray(arrayFirst);
Console.WriteLine("Второй массив:");
PrintArray(arraySecond);
Console.WriteLine("Результирующая матрица:");
int[,] resultArray = ProductOfTwoMatrices(arrayFirst, arraySecond);

PrintArray(resultArray);

//Произведение матриц
int[,] ProductOfTwoMatrices(int[,] arrayFirst, int[,] arraySecond)
{
    int[,] resultArray = new int [2, 2];
    int aRows = arrayFirst.GetLength(0); int aColumns = arrayFirst.GetLength(1);
    int bRows = arraySecond.GetLength(0); int bColumns = arraySecond.GetLength(1);
    
    for (int i = 0; i < aRows; i++)
    {
        for (int j = 0; j < bColumns; j++) {
            for (int k = 0; k < aColumns; k++){
                resultArray[i, j] += arrayFirst[i, k] * arraySecond[k, j];
            }
        }
    }
    return resultArray;
}


int [,] CreateArray ()
{
    int [,] Array = new int [2, 2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = new Random().Next(1, 10);
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