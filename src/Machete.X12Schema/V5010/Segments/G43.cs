namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G43 :
        X12Segment
    {
        Value<string> MarketAreaCodeQualifier { get; }
        
        Value<string> MarketAreaCodeIdentifier { get; }
        
        Value<string> Description { get; }
        
        Value<string> ClassOfTradeCode { get; }
    }
}