namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class V2Map :
        X12SegmentMap<V2, X12Entity>
    {
        public V2Map()
        {
            Id = "V2";
            Name = "Vessel Information";
            
            Value(x => x.LocationIdentifier, 1, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ReferenceIdentification, 2, x => x.MinLength(1).MaxLength(50));
            Value(x => x.Weight1, 3, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightUnitCode1, 4, x => x.FixedLength(1));
            Value(x => x.Weight2, 5, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightUnitCode2, 6, x => x.FixedLength(1));
            Value(x => x.Weight3, 7, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightUnitCode3, 8, x => x.FixedLength(1));
            Value(x => x.Weight4, 9, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightUnitCode4, 10, x => x.FixedLength(1));
            Value(x => x.Weight5, 11, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightUnitCode5, 12, x => x.FixedLength(1));
            Value(x => x.Name, 13, x => x.MinLength(1).MaxLength(60));
            Value(x => x.Length, 14, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode, 15, x => x.FixedLength(2));
            Value(x => x.Quantity1, 16, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Quantity2, 17, x => x.MinLength(1).MaxLength(15));
        }
    }
}