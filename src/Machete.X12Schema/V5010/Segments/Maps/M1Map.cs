namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M1Map :
        X12SegmentMap<M1, X12Entity>
    {
        public M1Map()
        {
            Id = "M1";
            Name = "Insurance";
            
            Value(x => x.CountryCode, 1, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.CarriageValue, 2, x => x.MinLength(2).MaxLength(8));
            Value(x => x.DeclaredValue, 3, x => x.MinLength(2).MaxLength(12));
            Value(x => x.RateOrValueQualifier1, 4, x => x.FixedLength(2));
            Value(x => x.EntityIdentifierCode, 5, x => x.MinLength(2).MaxLength(3));
            Value(x => x.FreeformInformation, 6, x => x.MinLength(1).MaxLength(30));
            Value(x => x.RateOrValueQualifier2, 7, x => x.FixedLength(2));
            Value(x => x.MonetaryAmount, 8, x => x.MinLength(1).MaxLength(18));
            Value(x => x.PercentQualifier1, 9, x => x.MinLength(1).MaxLength(2));
            Value(x => x.PercentageAsDecimal1, 10, x => x.MinLength(1).MaxLength(10));
            Value(x => x.PercentQualifier2, 11, x => x.MinLength(1).MaxLength(2));
            Value(x => x.PercentageAsDecimal2, 12, x => x.MinLength(1).MaxLength(10));
        }
    }
}