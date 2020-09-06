namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface V3 :
        X12Segment
    {
        Value<string> CurrentPortOfLoading { get; }
        
        Value<DateTime> Date1 { get; }

        Value<string> NextPortOfLoading { get; }
        
        Value<DateTime> Date2 { get; }
    }
}