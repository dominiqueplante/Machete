namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface Y7 :
        X12Segment
    {
        Value<int> Priority { get; }
        
        Value<int> PriorityCode { get; }
        
        Value<string> PriorityCodeQualifier { get; }
        
        Value<int> PortCallFileNumber { get; }
        
        Value<DateTime> Date { get; }
    }
}