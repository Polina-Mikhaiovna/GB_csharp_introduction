// Собрать строку с числами от а до b, a <= b
// Циклом

string NumbersFor(int a, int b)
{
	string result = String.Empty;
	for(int i = a; i <= b; i++)
	{
		result += $"{i} ";
	}
	return result;
}

Console.WriteLine($"{NumbersFor(4, 8)}");

// Собрать строку с числами от а до b, a <= b
// С помощью рекурсии

string res = String.Empty;

string NumbersRec(int a, int b)
{
	if(a < b) return $"{a} " + NumbersRec(a+1, b);
	else return $"{b}";

}

Console.WriteLine(NumbersRec(1, 5));

// Вычислить а в степени n
// Циклом

int PowerFor(int a, int n)
{
	int result = 1;
	for(int i = 1; i <= n; i++) result *= a;
	return result;
}

Console.WriteLine(PowerFor(5,3));

// Вычислить а в степени n
// Рекурсией

int PowerRec(int a, int n)
{
	if (n != 0) { return PowerRec(a, n-1) * a;}
	else return 1;
}

Console.WriteLine(PowerRec(4,3));