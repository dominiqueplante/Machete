namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface BFR :
        X12Segment
    {
        Value<string> TransactionSetPurposeCode { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<string> ReleaseNumber { get; }
        
        Value<string> ScheduleTypeQualifier { get; }
        
        Value<string> ScheduleQuantityQualifier { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<DateTime> Date3 { get; }
        
        Value<DateTime> Date4 { get; }
        
        Value<string> ContractNumber { get; }
        
        Value<string> PurchaseOrderNumber { get; }
        
        Value<string> PlanningScheduleTypeCode { get; }
        
        Value<string> ActionCode { get; }
    }
}