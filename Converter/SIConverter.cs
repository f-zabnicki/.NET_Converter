using Converter.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    internal static class SIConverter
    {
        static Dictionary<Unit, decimal> ConvertionRatio = new Dictionary<Unit, decimal>()
        {
            {Unit.Gram, 1m },
            {Unit.Miligram, 0.001m }
        };
        public static UnitValue ToBaseUnit(UnitValue input)
        {
            if (ConvertionRatio.TryGetValue(input.Unit, out decimal ratio))
            {
                var value = input.Value * ratio;
                return new UnitValue(value, Unit.Gram);
            }
            else
            {
                throw new NotSupportedException("Not supported Unit");
            }
        }
        public static UnitValue ToDesignated(UnitValue input, Unit unit)
        {
            var value = input.Value * ConvertionRatio[unit];
            return new UnitValue(value, unit);
        }
    }
}
