namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class AT8Map :
        X12SegmentMap<AT8, X12Entity>
    {
        public AT8Map()
        {
            Id = "AT8";
            Name = "Shipment Weight, Packaging and Quantity Data";
            
            Value(x => x.WeightQualifier, 1, x => x.MinLength(1).MaxLength(2));
            Value(x => x.WeightUnitCode, 2, x => x.FixedLength(1));
            Value(x => x.Weight, 3, x => x.MinLength(1).MaxLength(10));
            Value(x => x.LadingQuantity1, 4, x => x.MinLength(1).MaxLength(7));
            Value(x => x.LadingQuantity2, 5, x => x.MinLength(1).MaxLength(7));
            Value(x => x.VolumeUnitQualifier, 6, x => x.FixedLength(1));
            Value(x => x.Volume, 7, x => x.MinLength(1).MaxLength(8));
        }
    }
}