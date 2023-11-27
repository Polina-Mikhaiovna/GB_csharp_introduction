// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int start = ReadConsoleInt("Введите желаемое начало диапазона чётных натуральных чисел:");
int end = ReadConsoleInt("Введите желаемый конец диапазона чётных натуральных чисел: ");
PrintInt(start);

int ReadConsoleInt(string message)
{
	Console.Write(message);
	return Convert.ToInt32(Console.ReadLine());
}


void PrintInt(int start)
{
	if (start <= end) Console.Write($" {PrintInt(start+1)}");
}
// Console.WriteLine($"{start} {end}");