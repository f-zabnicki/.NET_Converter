using Converter.Data;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConverterConsole
{
    class Program
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
            Regex find = new Regex("(\\d{1,})+(\\w{1,3})+,\\s+(\\w{1,3})");
            Console.WriteLine("Hello, please input conversion");
            try
            {
                MatchCollection match = find.Matches(Console.ReadLine());
                var value = Decimal.Parse(match[0].Groups[1].ToString());
                var from = new UnitValue(value, new SystemUnit(units[match[0].Groups[2].Value]));
                var to = new SystemUnit(units[match[0].Groups[3].Value]);
                var outcome = Converter.Converter.Convert(from, to).ToString();
                Console.WriteLine(outcome.ToString());
            }
            catch (Exception)
            {
                throw new Exception("Wrong syntax or number");
            }

            Console.ReadLine();

        }
    }
}
