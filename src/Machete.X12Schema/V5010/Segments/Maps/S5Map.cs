namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class S5Map :
        X12SegmentMap<S5, X12Entity>
    {
        public S5Map()
        {
            Id = "S5";
            Name = "Stop-off Details";
            
            Value(x => x.StopSequenceNumber, 1, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.StopReasonCode, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.Weight, 3, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightUnitCode, 4, x => x.FixedLength(1));
            Value(x => x.NumberOfUnitsShipped, 5, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitOrBasisForMeasurementCode, 6, x => x.FixedLength(2));
            Value(x => x.Volume, 7, x => x.MinLength(2).MaxLength(8));
            Value(x => x.VolumeUnitQualifier, 8, x => x.FixedLength(1));
            Value(x => x.Description, 9, x => x.MinLength(1).MaxLength(80));
            Value(x => x.StandardPointLocationCode, 10, x => x.MinLength(6).MaxLength(9));
            Value(x => x.AccomplishCode, 11, x => x.FixedLength(1));
        }
    }
}