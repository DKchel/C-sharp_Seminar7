// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите первую размерность");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую размерность");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

double sum = 0;

for (int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    decimal arithmetic = Math.Round((decimal)sum / rows, 1);
    Console.WriteLine($"Среднее арифметическое столбца {j + 1} равно {arithmetic}");
    sum = 0;
}

