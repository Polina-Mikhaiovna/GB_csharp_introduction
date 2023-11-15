// поиск факториала f(n) = f(1) * f(2) ... * f(n)

int f = 8;

int Factorial(int i){
	
	if(i == 1) return 1;
	else return i * Factorial(i-1);
}

Console.WriteLine(Factorial(f));
Console.WriteLine();
// поиск чисел Фибоначчи каждое следующее число это сумма двух предыдущих
// f(n) = f(n-1) + f(n-2)

int Fibonacchi(int fib){
	
	if(fib == 1 || fib == 2) return 1;
	else return Fibonacchi(fib - 1) + Fibonacchi(fib - 2);
}

int len = 11;
for(int i = 1; i < len; i++){
	if (i == len - 1) Console.WriteLine(Fibonacchi(i));
	else Console.Write($"{Fibonacchi(i)} ");
}

