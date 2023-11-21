// Задайте двумерный массив размером m*n
// заполненный рандомными вещественными числами

// инициализировать двумерный массив
// пригласить пользователя к вводу
// считать 2 числа из консоли
// в цикле каждому итому житому элементу присвоить рандомное вещественное значение
// вывести в красивом виде Round(Double, Int32)


// !!!!!!!!!!!!!   НЕ ДОДЕЛАНО    !!!!!!!!!!



int rows = ReadConsoleInt("Введите количество строк двумерного массива: ");
int cols = ReadConsoleInt("Введите количество столбцов двумерного массива: ");

double[,] = new double[rows, cols];

double value = new Random().NextDouble();

Console.WriteLine($"{Math.Round(value, 2)}");

int ReadConsoleInt(string message)
{
	Console.Write(message);
	return Convert.ToInt32(Console.ReadLine());
}