//

string[,] fild = new string[22,10];

void PrintEmptyFild(string[,] fild){
	for(int i = 0; i < fild.GetLength(0); i++){
		for(int j = 0; j < fild.GetLength(1); j++){
			Console.Write("0");
		}
		Console.WriteLine();
	}
}

PrintEmptyFild(fild);

int figure = 1;
int x = 0;
int y = 3;
PrintHorizontalStick(x, y);

while (Console.ReadLine() != "q"){
	
	Changes(figure, x, y);
}

int NewRandomFigure(){
	int fig = new Random().Next(1,3);
	if (fig == 1){
		PrintHorizontalStick(0,3);
	}
	if (fig == 2){
		PrintVerticalStick(0,3);
	}
	return fig;
}


void PrintHorizontalStick(int x, int y){
	Console.Clear();
	for(int i = 0; i < fild.GetLength(0); i++){
		for(int j = 0; j < fild.GetLength(1); j++){
			if ((i == x && j == y) || (i == x && j == y+1)
				|| (i == x && j == y+2) || (i == x && j == y+3)){
				Console.Write("#");
			}
			else Console.Write("-");

		}
		Console.WriteLine();
	}
}

void PrintVerticalStick(int x, int y){
	Console.Clear();
	for(int i = 0; i < fild.GetLength(0)-3; i++){
		for(int j = 0; j < fild.GetLength(1); j++){
			if ((i == x && j == y) || (i+1 == x && j == y)
				|| (i == x+2 && j == y) || (i == x+3 && j == y)){
				Console.Write("#");
			}
			else Console.Write("-");

		}
		Console.WriteLine();
	}
}

// void PositionOfStick(){
// 	i = i;

// }

void Changes(int fig, int x, int y){
	if (Console.ReadLine() == "s"){ //down
		MoveDown(fig, x, y);
	}
	else Console.Write("Wrong simbol, use just 's'");
}

void MoveDown(int fig, int x, int y){
	if (fig == 1 && x < fild.GetLength(0)){ // horizontal
		x++;
		PrintHorizontalStick(x, y);
	}
	else NewRandomFigure();
	
	if (fig == 2 && x < fild.GetLength(0) - 3){ //vertikal
		x++;
		PrintVerticalStick(x, y);
	}
	else NewRandomFigure();
}

// void Turn(int oldPosition){
// 	if(fig == 1){

// 	}
// }

