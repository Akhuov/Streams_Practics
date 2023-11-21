//var text = Console.ReadLine();
//File.AppendAllTextAsync("iceMan.txt", text);

bool isExist = File.Exists("iceMan.txt");
if (isExist) Console.WriteLine("File bor");

FileInfo fileInfo = new FileInfo("iceMan.txt");
var extention = fileInfo.Extension;
Console.WriteLine(extention);



File.SetCreationTime("iceMan.txt", DateTime.UtcNow);