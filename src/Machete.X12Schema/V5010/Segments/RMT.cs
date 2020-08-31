namespace Machete.X12Schema.V5010
{
    using X12;


    public interface RMT :
        X12Segment
    {
        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }

        Value<decimal> MonetaryAmount1 { get; }
        
        Value<decimal> MonetaryAmount2 { get; }
        
        Value<decimal> MonetaryAmount3 { get; }
        
        Value<decimal> MonetaryAmount4 { get; }
        
        Value<decimal> MonetaryAmount5 { get; }
        
        Value<decimal> MonetaryAmount6 { get; }

        Value<string> AdjustmentReasonCode { get; }

        Value<string> Description { get; }
    }
}