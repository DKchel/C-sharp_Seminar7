// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

int sum0 = 0;
int sum1 = 0;
int sum2 = 0;
int sum3 = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j == 0) { sum0 += matrix[i, j]; }

        else if (j == 1) { sum1 += matrix[i, j]; }

        else if (j == 2) { sum2 += matrix[i, j]; }

        else if (j == 3) { sum3 += matrix[i, j]; }

    }
}

decimal arithmetic0 = Math.Round((decimal)sum0 / 3, 1);
decimal arithmetic1 = Math.Round((decimal)sum1 / 3, 1);
decimal arithmetic2 = Math.Round((decimal)sum2 / 3, 1);
decimal arithmetic3 = Math.Round((decimal)sum3 / 3, 1);

Console.WriteLine($"Среднее арифметическое каждого столбца: {arithmetic0}; {arithmetic1}; {arithmetic2}; {arithmetic3}");