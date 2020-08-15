namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class N5Map :
        X12SegmentMap<N5, X12Entity>
    {
        public N5Map()
        {
            Id = "N5";
            Name = "Equipment Ordered";
            
            Value(x => x.EquipmentLength, 1, x => x.MinLength(4).MaxLength(5));
            Value(x => x.WeightCapacity, 2, x => x.MinLength(2).MaxLength(3));
            Value(x => x.CubicCapacity, 3, x => x.MinLength(2).MaxLength(5));
            Value(x => x.CarTypeCode, 4, x => x.MinLength(1).MaxLength(4));
            Value(x => x.MetricQualifier, 5, x => x.FixedLength(1));
            Value(x => x.Height, 6, x => x.MinLength(1).MaxLength(8));
            Value(x => x.LadingPercentage, 7, x => x.MinLength(2).MaxLength(4));
            Value(x => x.LadingPercentQualifier, 8, x => x.FixedLength(1));
            Value(x => x.EquipmentDescriptionCode, 9, x => x.FixedLength(2));
        }
    }
}