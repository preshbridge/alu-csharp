using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "Holberton School";
        Console.WriteLine("{0}{0}{0}", str);        // Print the string 3 times
        Console.WriteLine(str.Substring(0, 9));     // Print the first 9 characters
    }
}