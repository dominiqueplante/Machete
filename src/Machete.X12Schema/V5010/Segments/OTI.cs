namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface OTI :
        X12Segment
    {
        Value<string> ApplicationAcknowledgementCode { get; }

        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }
        
        Value<string> ApplicationSendersCode { get; }
        
        Value<string> ApplicationReceiversCode { get; }
        
        Value<DateTime> Date { get; }
        
        Value<TimeSpan> Time { get; }
        
        Value<string> GroupControlNumber { get; }
        
        Value<string> TransactionSetControlNumber { get; }
        
        Value<string> TransactionSetIdentifierNumber { get; }
        
        Value<string> VersionReleaseOrIndustryIdentifierCode { get; }
        
        Value<string> TransactionSetPurposeCode { get; }
        
        Value<string> TransactionTypeCode { get; }
        
        Value<string> ApplicationType { get; }
        
        Value<string> ActionCode { get; }
        
        Value<string> TransactionHandlingCode { get; }
        
        Value<string> StatusReasonCode { get; }
    }
}