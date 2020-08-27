namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class CRDMap :
        X12SegmentMap<CRD, X12Entity>
    {
        public CRDMap()
        {
            Id = "CRD";
            Name = "Content Reporting Detail";
            
            Value(x => x.CountryCode, 1, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.AmountQualifierCode, 2, x => x.MinLength(1).MaxLength(3));
            Value(x => x.MonetaryAmount, 3, x => x.MinLength(1).MaxLength(18));
            Value(x => x.PercentIntegerFormat, 4, x => x.MinLength(1).MaxLength(3));
        }
    }
}