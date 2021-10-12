using System;
using System.Collections.Generic;
using System.Text;

namespace Converter.Data
{
    public class UnitValue
    {
        public decimal Value { get; }
        public Unit Unit { get; }
        public UnitValue(decimal value, Unit unit)
        {
            Value = value;
            Unit = unit;
        }
        //TODO ToString()
    }
}
