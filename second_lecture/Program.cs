// Задание: заменить в cтроке text	" " на "|"
//									"c" на "C"
//

string text = "Console.WriteLine [main cf9835e] add folder sec_lec\n7 files changed, 162 insertions(+)";
char old_symbol;
char new_symbol;
old_symbol = ' ';
new_symbol = '|';
string result_string = Replase(text, old_symbol, new_symbol);


string Replase(string origin_string, char oldV, char newV){
	
	string changed_string = String.Empty;
	int length = origin_string.Length;
	
	for (int i = 0; i < length; i++) {
		if (origin_string[i] == oldV) {
			changed_string = changed_string	+ $"{newV}";
			Console.WriteLine(changed_string);
			break;
		}
		else changed_string = changed_string + $"{origin_string[i]}";
	}
	return changed_string;
}


Console.WriteLine(result_string);