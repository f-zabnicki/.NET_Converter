using System;
using System.Text.RegularExpressions;

namespace ConverterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex find = new Regex("([0-9]+[0-9])|([a-z]+[a-z])|([a-z])");
            Console.WriteLine("Hello, please input conversion");
            Match match = find.Match(Console.ReadLine());
            Console.WriteLine(match.Value);
            Console.ReadLine();

        }
    }
}
