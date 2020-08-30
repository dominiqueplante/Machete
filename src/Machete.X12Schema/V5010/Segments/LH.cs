namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LH :
        X12Segment
    {
        Value<int> LadingLineItemNumber { get; }
        
        Value<string> HazardousMnemonicCode { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<string> ReferenceIdentificationQualifier { get; }
        
        Value<string> ReportableQuantityCode { get; }
        
        Value<string> LimitedQuantityIndicationCode { get; }
    }
}