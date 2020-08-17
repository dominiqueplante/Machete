namespace Machete.X12Schema.V5010
{
    using X12;


    public interface M1 :
        X12Segment
    {
        Value<string> CountryCode { get; }

        Value<string> CarriageValue { get; }

        Value<string> DeclaredValue { get; }

        Value<string> RateOrValueQualifier1 { get; }

        Value<string> EntityIdentifierCode { get; }

        Value<string> FreeformInformation { get; }

        Value<string> RateOrValueQualifier2 { get; }

        Value<decimal> MonetaryAmount { get; }

        Value<string> PercentQualifier1 { get; }

        Value<decimal> PercentageAsDecimal1 { get; }

        Value<string> PercentQualifier2 { get; }

        Value<decimal> PercentageAsDecimal2 { get; }
    }
}