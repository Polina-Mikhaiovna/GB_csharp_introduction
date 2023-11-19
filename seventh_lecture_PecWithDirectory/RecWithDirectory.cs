string path = "/home/mint/csharp/GB_csharp_introduction/";
DirectoryInfo di = new DirectoryInfo(path); // Типы позволяющие получить информацию о файле и о папке
Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
	Console.WriteLine(fi[i].Name);
}
//										/ это искусственный приём для красивых отступов
void CatalogInfo(string path, string indent = "") 
{
	DirectoryInfo catalog = new DirectoryInfo(path); // записываем каталог всех файлов из директории
	
	DirectoryInfo[] catalogs = catalog.GetDirectories();  
	for (int i = 0; i < catalogs.Length; i++)
	{
		Console.WriteLine($"{indent}{catalogs[i].Name}"); // Выводим инфу о текущем каталоге
		CatalogInfo(catalogs[i].FullName, indent + " "); // рекурсивно смотрим все папки которые записали в catalog
	}


FileInfo[] files = catalog.GetFiles(); // после завершения вывода папок, получаем список файлов в директории

for (int i = 0; i < files.Length; i++)
{
	Console.WriteLine($"{indent}{files[i].Name}");
}
}
CatalogInfo(path);