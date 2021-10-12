using System;
using System.Collections.Generic;
using System.Text;

namespace Converter.Data
{
    public class SystemUnit
    {
        Dictionary<Unit, MeasureSystem> UnitSystem = new Dictionary<Unit, MeasureSystem>()
        {
            {Unit.Gram, MeasureSystem.SI },
            {Unit.Miligram, MeasureSystem.SI },
            {Unit.Pound, MeasureSystem.Imperial },
            {Unit.Ounce, MeasureSystem.Imperial },
        };
        internal Unit Unit { get; }
        internal MeasureSystem System { get; set; }
        public SystemUnit(Unit unit)
        {
            Unit = unit;
            System = UnitSystem[unit];
        }
    }
}
