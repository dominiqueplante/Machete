namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface G22 :
        X12Segment
    {
        Value<string> PrePricedOptionCode { get; }
        
        Value<decimal> PriceNewSuggestedRetail { get; }
        
        Value<int> MultiplePriceQuantity { get; }
        
        Value<string> FreeformMessage { get; }
        
        Value<DateTime> Date { get; }
    }
}