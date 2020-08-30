namespace Machete.X12Schema.V5010
{
    using X12;


    public interface TIA :
        X12Segment
    {
        Value<C0037> TaxFieldIdentification { get; }

        Value<decimal> MonetaryAmount02 { get; }

        Value<string> FixedFormatInformation { get; }

        Value<decimal> Quantity { get; }

        Value<C001> CompositeUnitOfMeasure { get; }

        Value<decimal> PercentageAsDecimal { get; }

        Value<decimal> MonetaryAmount07 { get; }
    }
}