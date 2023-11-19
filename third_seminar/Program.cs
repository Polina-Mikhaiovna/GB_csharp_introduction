int readCoordinates(string message)
{
	Console.WriteLine(message);
	string value = Console.ReadLine();
	return int.Parse(value);
}

int x1 = readCoordinates("Введите X1");
int y1 = readCoordinates("Введите Y1");
int z1 = readCoordinates("Введите Z1");
int x2 = readCoordinates("Введите X2");
int y2 = readCoordinates("Введите Y2");
int z2 = readCoordinates("Введите Z2");

double distanse(int x1, int y1, int z1, int x2, int y2, int z2)
{
	int xPowOfDif = (x1 - x2)*(x1 - x2);
	int yPowOfDif = (y1 - y2)*(y1 - y2);
	int zPowOfDif = (z1 - z2)*(z1 - z2);
	double result = Math.Sqrt((xPowOfDif + yPowOfDif + zPowOfDif));
	return result;
}
Console.WriteLine(distanse(x1, y1, z1, x2, y2, z2));