namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface G36 :
        X12Segment
    {
        Value<string> PriceListNumber { get; }
        
        Value<string> PriceListIssueNumber { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> PriceConditionAppliesCode { get; }
    }
}