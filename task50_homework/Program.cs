// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

Console.WriteLine("Введите позицию элемента строки (i): "); // Отсчтёт i==0
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите позицию элемента столбца (j): "); // Отсчтёт j==0
int column = int.Parse(Console.ReadLine());

if (row < 0 || row >= matrix.GetLength(0) || column < 0 || column > matrix.GetLength(1))
{
    Console.WriteLine($"Элемент со значениями i={row}, j={column} не существует в массиве");
}
else
{
    Console.WriteLine($"Значение элемента массива i={row}, j={column}: {matrix[row, column]}");
}