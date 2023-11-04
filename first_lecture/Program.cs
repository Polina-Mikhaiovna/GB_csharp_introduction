// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.Clear();

// Вершины треугольника х(1,70)
//						y(1,20)
int count = 0;

int ax = 1, ay = 30;
int bx = 50, by = 1;
int cx = 100, cy = 30;

int tempX = ax, tempY = ay;

// Console.SetCursorPosition(ax, ay);
// Console.WriteLine("#");
// Console.SetCursorPosition(bx, by);
// Console.WriteLine("#");
// Console.SetCursorPosition(cx, cy);
// Console.WriteLine("#");

while (count < 10000) {
	int random_top = new Random().Next(1,4);
	if (random_top == 1){
		tempX = (tempX + ax)/2;
		tempY = (tempY + ay)/2;
	}
	if (random_top == 2){
		tempX = (tempX + bx)/2;
		tempY = (tempY + by)/2;
	}
	if (random_top == 3){
		tempX = (tempX + cx)/2;
		tempY = (tempY + cy)/2;
	}

Console.SetCursorPosition(tempX, tempY);
Console.Write("#");
count++;
}

Console.SetCursorPosition(ax, ay);
for(int i = 1; i <= cx; i++) {
	Console.Write("_");
}
Console.WriteLine("\n");