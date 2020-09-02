namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface M0 :
        X12Segment
    {
        Value<string> LetterOfCreditNumber { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<DateTime> Date3 { get; }
    }
}