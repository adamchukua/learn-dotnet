using ConsoleApp1;

Console.WriteLine("1 - Word counter\n2 - Calculator");
Console.Write("Choose program: ");

var menu = new MenuProgram(Convert.ToInt32(Console.ReadLine()));
menu.Execute();