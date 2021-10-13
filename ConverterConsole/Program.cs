using Converter.Data;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConverterConsole
{
    public class Program
    {
        public static Dictionary<string, Unit> units = new Dictionary<string, Unit>() 
        {
            {"g", Unit.Gram },
            {"mg", Unit.Miligram },
            {"lbs", Unit.Pound },
            {"oz", Unit.Ounce},
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please input conversion");
            try
            {
                string input = Console.ReadLine();
                MatchCollection match = FindValuesUsingRegex(input);
                decimal value = Decimal.Parse(match[0].Groups[1].ToString());
                UnitValue from = new UnitValue(value, new SystemUnit(units[match[0].Groups[2].Value]));
                SystemUnit to = new SystemUnit(units[match[0].Groups[3].Value]);
                UnitValue outcome = Converter.Converter.Convert(from, to);
                Console.WriteLine(outcome.ToString());
            }
            catch (Exception)
            {
                throw new Exception("Wrong syntax or number");
            }
            Console.ReadLine();
        }
        public static MatchCollection FindValuesUsingRegex(string userInput)
        {
            Regex find = new Regex("(\\d{1,})+(\\w{1,3})+,\\s+(\\w{1,3})");
            return find.Matches(userInput);
        }
    }
}
