namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface BGN :
        X12Segment
    {
        Value<string> TransactionSetPurposeCode { get; }

        Value<string> ReferenceIdentification1 { get; }
        
        Value<DateTime> Date { get; }

        Value<TimeSpan> Time { get; }

        Value<string> TimeCode { get; }
        
        Value<string> ReferenceIdentification2 { get; }

        Value<string> TransactionTypeCode { get; }
        
        Value<string> ActionCode { get; }
        
        Value<string> SecurityLevelCode { get; }
    }
}