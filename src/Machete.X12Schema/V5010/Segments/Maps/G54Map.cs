namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G54Map :
        X12SegmentMap<G54, X12Entity>
    {
        public G54Map()
        {
            Id = "G54";
            Name = "Module Description";
            
            Value(x => x.Quantity, 1, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.UnitOrBasisForMeasurementCode, 2, x=> x.FixedLength(2).IsRequired());
            Value(x => x.UPCCaseCode, 3, x=> x.FixedLength(12));
            Value(x => x.ProductOrServiceIdQualifier, 4, x=> x.FixedLength(2));
            Value(x => x.ProductOrServiceId, 5, x => x.MinLength(1).MaxLength(48));
            Value(x => x.FreeformDescription, 6, x => x.MinLength(1).MaxLength(45));
        }
    }
}