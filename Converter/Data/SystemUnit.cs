using System;
using System.Collections.Generic;
using System.Text;

namespace Converter.Data
{
    public class SystemUnit
    {
        internal Unit Unit { get; }
        internal MeasureSystem System { get; set; }
        public SystemUnit(Unit unit)
        {
            Unit = unit;
            System = UnitSystemDictionary.AssignSystem(unit);
        }
    }
}
