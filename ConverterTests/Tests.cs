using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConverterConsole;
using System.Text.RegularExpressions;
using Converter.Data;
using System;

namespace ConverterTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [DataRow ("1529g, mg", "1529", "g", "mg")]
        [DataRow ("15292221oz, g", "15292221", "oz", "g")]
        [DataRow ("19lbt, oz", "19", "lbt", "oz")]
        [DataRow ("22991mg, lbt", "22991", "mg", "lbt")]
        public void RegexConvertingInputIntoValuesGroups(string input, string a, string b, string c)
        {
            MatchCollection outcome;
            outcome = Program.FindValuesUsingRegex(input);
            Assert.IsTrue(outcome[0].Groups[1].ToString() == a);
            Assert.IsTrue(outcome[0].Groups[2].ToString() == b);
            Assert.IsTrue(outcome[0].Groups[3].ToString() == c);
        }

        [TestMethod]
        [DataRow("18273", Unit.Gram, Unit.Miligram)]
        [DataRow("11208273", Unit.Gram, Unit.Miligram)]
        [DataRow("73", Unit.Gram, Unit.Miligram)]
        [DataRow("11273", Unit.Gram, Unit.Miligram)]
        [DataRow("12389172419", Unit.Gram, Unit.Miligram)]
        [DataRow("3", Unit.Gram, Unit.Miligram)]
        [DataRow("1", Unit.Gram, Unit.Miligram)]
        public void GramToMiligramConvertion(string value, Unit from, Unit to)
        {
            var parsed = Decimal.Parse(value);
            SystemUnit fromUnit = new SystemUnit(from);
            SystemUnit expectedUnit = new SystemUnit(to);
            UnitValue inputValue = new UnitValue(parsed, fromUnit);
            UnitValue outcome = Converter.Converter.Convert(inputValue, expectedUnit);
            Assert.AreEqual(parsed * 0.001m, outcome.Value);
        }

        [TestMethod]
        [DataRow("18273", Unit.Miligram, Unit.Gram)]
        [DataRow("11208273", Unit.Miligram, Unit.Gram)]
        [DataRow("73", Unit.Miligram, Unit.Gram)]
        [DataRow("11273", Unit.Miligram, Unit.Gram)]
        [DataRow("1125238273", Unit.Miligram, Unit.Gram)]
        [DataRow("3", Unit.Miligram, Unit.Gram)]
        [DataRow("1", Unit.Miligram, Unit.Gram)]
        public void MiligramToGramConvertion(string value, Unit from, Unit to)
        {
            var parsed = Decimal.Parse(value);
            SystemUnit fromUnit = new SystemUnit(from);
            SystemUnit expectedUnit = new SystemUnit(to);
            UnitValue inputValue = new UnitValue(parsed, fromUnit);
            UnitValue outcome = Converter.Converter.Convert(inputValue, expectedUnit);
            Assert.AreEqual(parsed * 0.001m, outcome.Value);
        }

        [TestMethod]
        [DataRow("18273", Unit.Pound, Unit.Ounce)]
        [DataRow("11208273", Unit.Pound, Unit.Ounce)]
        [DataRow("73", Unit.Pound, Unit.Ounce)]
        [DataRow("11273", Unit.Pound, Unit.Ounce)]
        [DataRow("1125238273", Unit.Pound, Unit.Ounce)]
        [DataRow("3", Unit.Pound, Unit.Ounce)]
        [DataRow("1", Unit.Pound, Unit.Ounce)]
        public void PoundsToOuncesConvertion(string value, Unit from, Unit to)
        {
            var parsed = Decimal.Parse(value);
            SystemUnit fromUnit = new SystemUnit(from);
            SystemUnit expectedUnit = new SystemUnit(to);
            UnitValue inputValue = new UnitValue(parsed, fromUnit);
            UnitValue outcome = Converter.Converter.Convert(inputValue, expectedUnit);
            Assert.AreEqual(parsed * 0.0625m, outcome.Value);
        }

        [TestMethod]
        [DataRow("18273", Unit.Ounce, Unit.Pound)]
        [DataRow("11208273", Unit.Ounce, Unit.Pound)]
        [DataRow("73", Unit.Ounce, Unit.Pound)]
        [DataRow("11273", Unit.Ounce, Unit.Pound)]
        [DataRow("1125238273", Unit.Ounce, Unit.Pound)]
        [DataRow("3", Unit.Ounce, Unit.Pound)]
        [DataRow("1", Unit.Ounce, Unit.Pound)]
        public void OuncesToPoundsConvertion(string value, Unit from, Unit to)
        {
            var parsed = Decimal.Parse(value);
            SystemUnit fromUnit = new SystemUnit(from);
            SystemUnit expectedUnit = new SystemUnit(to);
            UnitValue inputValue = new UnitValue(parsed, fromUnit);
            UnitValue outcome = Converter.Converter.Convert(inputValue, expectedUnit);
            Assert.AreEqual(parsed * 0.0625m, outcome.Value);
        }
    }
}
