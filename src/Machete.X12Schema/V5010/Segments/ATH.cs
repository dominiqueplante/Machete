namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface ATH :
        X12Segment
    {
        Value<string> ResourceAuthorizationCode { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<decimal> Quantity1 { get; }
        
        Value<decimal> Quantity2 { get; }
        
        Value<DateTime> Date2 { get; }
    }
}