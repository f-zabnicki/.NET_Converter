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
                return new UnitValue(value, new SystemUnit(Unit.Pound));
            }
            else
            {
                throw new NotSupportedException("Not supported Unit");
            }
        }
        public static UnitValue ToDesignated(UnitValue input, Unit unit)
        {
            if(ConvertionRatio.TryGetValue(unit, out decimal ratio))
            {
                var value = input.Value / ratio;
                return new UnitValue(value, new SystemUnit(unit));
            }
            else
            {
                throw new NotSupportedException("Not supported Unit in Imperial Converter");
            }
        }
    }
}
