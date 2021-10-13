using System;
using System.Collections.Generic;
using System.Text;

namespace Converter.Data
{
    internal static class UnitSystemDictionary
    {
        static Dictionary<Unit, MeasureSystem> UnitSystem = new Dictionary<Unit, MeasureSystem>()
        {
                {Unit.Gram, MeasureSystem.SI },
                {Unit.Miligram, MeasureSystem.SI },
                {Unit.Pound, MeasureSystem.Imperial },
                {Unit.Ounce, MeasureSystem.Imperial },
        };
        public static MeasureSystem AssignSystem(Unit unit)
        {
            return UnitSystem[unit];
        }
    }
}
