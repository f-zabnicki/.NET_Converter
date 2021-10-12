using Converter.Data;
using System;

namespace Converter
{
    public static class Converter
    {
        public static UnitValue Convert(UnitValue from, SystemUnit to)
        {
            if(from.System == to.System)
            { 
                if (from.System == MeasureSystem.Imperial)
                {
                    var temp = ImperialConverter.ToBaseUnit(from);
                    return ImperialConverter.ToDesignated(temp, to.Unit);
                }
                else
                {
                    var temp = SIConverter.ToBaseUnit(from);
                    return SIConverter.ToDesignated(temp, to.Unit);
                }
            }
            else
            {
                if (from.System == MeasureSystem.Imperial)
                {
                    var temp = ImperialConverter.ToBaseUnit(from);
                    var temp1 = CrossSystemConverter.CrossSystemConversion(temp);
                    return SIConverter.ToDesignated(temp1, to.Unit);
                }
                else
                {
                    var temp = SIConverter.ToBaseUnit(from);
                    var temp1 = CrossSystemConverter.CrossSystemConversion(temp);
                    return ImperialConverter.ToDesignated(temp1, to.Unit);
                }
            }
        }
    }
}
