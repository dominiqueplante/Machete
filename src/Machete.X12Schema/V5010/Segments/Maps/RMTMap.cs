namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class RMTMap :
        X12SegmentMap<RMT, X12Entity>
    {
        public RMTMap()
        {
            Id = "RMT";
            Name = "Adjustment";
            
            Value(x => x.ReferenceIdentificationQualifier, 1, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.ReferenceIdentification, 2, x => x.MinLength(2).MaxLength(50).IsRequired());
            Value(x => x.MonetaryAmount1, 3, x => x.MinLength(1).MaxLength(18));
            Value(x => x.MonetaryAmount2, 4, x => x.MinLength(1).MaxLength(18));
            Value(x => x.MonetaryAmount3, 5, x => x.MinLength(1).MaxLength(18));
            Value(x => x.MonetaryAmount4, 6, x => x.MinLength(1).MaxLength(18));
            Value(x => x.MonetaryAmount5, 7, x => x.MinLength(1).MaxLength(18));
            Value(x => x.MonetaryAmount6, 8, x => x.MinLength(1).MaxLength(18));
            Value(x => x.AdjustmentReasonCode, 9, x => x.FixedLength(2));
            Value(x => x.Description, 10, x => x.MinLength(1).MaxLength(80));
        }
    }
}