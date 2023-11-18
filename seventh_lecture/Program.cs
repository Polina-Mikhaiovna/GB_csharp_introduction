// Собрать строку с числами от а до b, a <= b

string NumbersString(int a, int b)
{
	string result = String.Empty;
	for(int i = a; i <= b; i++)
	{
		result += $"{i} ";
	}
	return result;
}

Console.WriteLine($"{NumbersString(4, 8)}");



string res = String.Empty;

string List(int a, int b)
{
	if(a <= b) return $"{a} " + List(a+1, b);
	else return String.Empty;

}

Console.WriteLine(List(1, 5));