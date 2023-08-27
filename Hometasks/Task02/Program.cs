// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

Console.WriteLine();

Console.WriteLine("Введите позицию искомого элемента");
int elemPos = Convert.ToInt32(Console.ReadLine());

if (elemPos / 10 <= rows && elemPos % 10 <= columns)
{
    Console.WriteLine("Искомый элемент: " + matrix[elemPos / 10, elemPos % 10]);
}

else
{
    Console.WriteLine("Такого элемента нет");
}