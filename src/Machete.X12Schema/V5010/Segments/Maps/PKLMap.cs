namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class PKLMap :
        X12SegmentMap<PKL, X12Entity>
    {
        public PKLMap()
        {
            Id = "PKL";
            Name = "Multi-Pack Configuration";
            
            Value(x => x.ProductOrServiceIdQualifier, 1, x=> x.FixedLength(2).IsRequired());
            Value(x => x.ProductOrServiceId, 2, x => x.MinLength(1).MaxLength(48).IsRequired());
            Value(x => x.UnitOrBasisForMeasurementCode1, 3, x=> x.FixedLength(2).IsRequired());
            Value(x => x.Quantity, 4, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.Height, 5, x => x.MinLength(1).MaxLength(8));
            Value(x => x.Width, 6, x => x.MinLength(1).MaxLength(8));
            Value(x => x.ItemDepth, 7, x => x.MinLength(1).MaxLength(6));
            Value(x => x.UnitOrBasisForMeasurementCode2, 8, x=> x.FixedLength(2));
            Value(x => x.GrossWeightPerPack, 9, x => x.MinLength(1).MaxLength(9));
            Value(x => x.UnitOrBasisForMeasurementCode3, 10, x=> x.FixedLength(2));
            Value(x => x.GrossVolumePerPack, 11, x => x.MinLength(1).MaxLength(9));
            Value(x => x.UnitOrBasisForMeasurementCode4, 12, x=> x.FixedLength(2));
            Value(x => x.YesNoConditionOrResponseCode, 13, x=> x.FixedLength(1));
        }
    }
}