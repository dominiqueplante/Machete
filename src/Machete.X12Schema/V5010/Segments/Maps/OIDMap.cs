namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class OIDMap :
        X12SegmentMap<OID, X12Entity>
    {
        public OIDMap()
        {
            Id = "OID";
            Name = "Order Information Detail";
            
            Value(x => x.ReferenceIdentification1, 1, x => x.MinLength(1).MaxLength(50));
            Value(x => x.PurchaseOrderNumber, 2, x => x.MinLength(1).MaxLength(22));
            Value(x => x.ReferenceIdentification2, 3, x => x.MinLength(1).MaxLength(50));
            Value(x => x.PackagingFormCode, 4, x => x.FixedLength(3));
            Value(x => x.Quantity, 5, x => x.MinLength(1).MaxLength(15));
            Value(x => x.WeightUnitCode, 6, x => x.FixedLength(1));
            Value(x => x.Weight, 7, x => x.MinLength(1).MaxLength(10));
            Value(x => x.VolumeUnitQualifier, 8, x => x.FixedLength(1));
            Value(x => x.Volume, 9, x => x.MinLength(1).MaxLength(8));
            Value(x => x.ApplicationErrorConditionCode, 10, x => x.MinLength(1).MaxLength(3));
            Value(x => x.ReferenceIdentification3, 11, x => x.MinLength(1).MaxLength(50));
        }
    }
}