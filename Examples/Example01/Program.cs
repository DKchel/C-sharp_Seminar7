// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


Console.WriteLine("Введите первую размерность");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую размерность");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] matrix = new int[rows, columns];

