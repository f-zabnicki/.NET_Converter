using Converter.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    internal static class ImperialConverter
    {
        static Dictionary<Unit, decimal> ConvertionRatio = new Dictionary<Unit, decimal>()
        {
            {Unit.Pound, 1m },
            {Unit.Ounce, 0.0625m }
        };
        public static UnitValue ToBaseUnit(UnitValue input)
        {
            if (ConvertionRatio.TryGetValue(input.Unit, out decimal ratio))
            {
                var value = input.Value * ratio;
                return new UnitValue(value, new SystemUnit(Unit.Gram));
            }
            else
            {
                throw new NotSupportedException("Not supported Unit");
            }
        }
        public static UnitValue ToDesignated(UnitValue input, Unit unit)
        {
            var value = input.Value * ConvertionRatio[unit];
            return new UnitValue(value, new SystemUnit(unit));
        }
    }
}
