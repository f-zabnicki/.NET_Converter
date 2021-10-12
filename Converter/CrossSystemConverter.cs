using Converter.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    internal static class CrossSystemConverter
    {
        const decimal PoundToGramRatio = 453.59237m;
        const decimal GramToPoundRatio = 0.0022046226m;
        public static UnitValue CrossSystemConversion(UnitValue input)
        {
            switch (input.Unit)
            {
                case Unit.Gram:
                    return new UnitValue(input.Value * GramToPoundRatio, new SystemUnit(Unit.Pound));
                case Unit.Pound:
                    return new UnitValue(input.Value * PoundToGramRatio, new SystemUnit(Unit.Gram));
                default:
                    throw new NotSupportedException("Not supported unit");
            }
        }
    }
}
