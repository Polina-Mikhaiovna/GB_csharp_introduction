// Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int start = ReadConsoleInt("Введите желаемое начало диапазона чётных натуральных чисел:");
int end = ReadConsoleInt("Введите желаемый конец диапазона чётных натуральных чисел: ");

void EvenInteger()
{
	
}


int ReadConsoleInt(string message)
{
	Console.Write(message);
	return Convert.ToInt32(Console.ReadLine());
}