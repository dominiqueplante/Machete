namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface BLR :
        X12Segment
    {
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<DateTime> Date { get; }

        Value<TimeSpan> Time { get; }
    }
}