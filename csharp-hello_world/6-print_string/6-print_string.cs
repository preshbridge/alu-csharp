using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
        Console.WriteLine(string.Concat(str, str, str));
        Console.WriteLine(str.Substring(0, 9));
        }
}