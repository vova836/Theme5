using System;
using System.Linq;
using CSharpShellCore;

namespace Themes5;

public static class Program
{
	public static void Main()
	{
	    //Задача1
	    Console.Write("Вывести информация об посещения сайта");
		string webPage = Console.ReadLine();
		Console.Write("Ввести номер ip адресса");
		int ipAddress = int.Parse(Console.ReadLine());
		Console.Write("Ввести посищения web браузера");
		string webBrowser = Console.ReadLine();
		Console.Write("Введите дату визита ");
        DateTime dateVisit = DateTime.Parse(Console.ReadLine());
		Console.Write("Введите время визита ");
        DateTime timeVisit = DateTime.Parse(Console.ReadLine());
		Console.ReadKey();
	}
}
