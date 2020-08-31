namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface G47 :
        X12Segment
    {
        Value<DateTime> Date { get; }
        
        Value<string> StatementNumber { get; }
    }
}