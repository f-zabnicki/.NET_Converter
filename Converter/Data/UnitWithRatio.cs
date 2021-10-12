using System;
using System.Collections.Generic;
using System.Text;

namespace Converter.Data
{
    internal class UnitWithRatio
    {
        public decimal Ratio { get; }
        public Unit Unit { get; }
        public UnitWithRatio(decimal ratio, Unit unit)
        {
            Ratio = ratio;
            Unit = unit;
        }
    }
}
