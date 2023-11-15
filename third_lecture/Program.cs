// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int[] array = {4, 5, 2, 1, 6, 3, 0};
PrintArray(array);
int len = array.Length;
int temp = 0;
int minPosition = 0;

void PrintArray(int[] array)
{
	for(int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}

void SelectionSort(int[] array)
{
	for (int i = 0; i < len - 1; i++)
	{
		minPosition = i;

		for (int j = 1 + i; j < len; j++)
		{
			if (array[minPosition] > array[j])
			{
			minPosition = j;	
			}

		temp = array[i];
		array[i] = array[minPosition];
		array[minPosition] = temp;
		}
	}
}
SelectionSort(array);
PrintArray(array);
