namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LHMap :
        X12SegmentMap<LH, X12Entity>
    {
        public LHMap()
        {
            Id = "LH";
            Name = "Mixed Hazardous Commodities";
            
            Value(x => x.LadingLineItemNumber, 1, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.HazardousMnemonicCode, 2, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.ReferenceIdentification, 3, x => x.MinLength(1).MaxLength(50).IsRequired());
            Value(x => x.ReferenceIdentificationQualifier, 4, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.ReportableQuantityCode, 5, x => x.FixedLength(2));
            Value(x => x.LimitedQuantityIndicationCode, 6, x => x.FixedLength(1));
        }
    }
}