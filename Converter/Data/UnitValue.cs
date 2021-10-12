using System;
using System.Collections.Generic;
using System.Text;

namespace Converter.Data
{
    public class UnitValue
    {
        internal decimal Value { get; }
        internal Unit Unit { get; }
        internal MeasureSystem System { get; }
        internal UnitValue(decimal value, SystemUnit unit)
        {
            Value = value;
            Unit = unit.Unit;
            System = unit.System;
        }
        //TODO ToString()
    }
}
