// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // [1, 10)
        }
    }
}
int[,] matrix = new int[3, 4];

FillArray(matrix);
Console.WriteLine("Наш двумерный массив: ");
PrintArray(matrix);

Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double mean = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        mean = mean + matrix[i, j];
    }
    Console.WriteLine($"{Math.Round(mean / 3, 2)}");
}