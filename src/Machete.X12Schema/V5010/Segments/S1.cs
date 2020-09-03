namespace Machete.X12Schema.V5010
{
    using X12;


    public interface S1 :
        X12Segment
    {
        Value<int> StopSequenceNumber { get; }
        
        Value<string> Name { get; }
        
        Value<string> IdentificationCodeQualifier { get; }
        
        Value<string> IdentificationCode { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> AccomplishCode { get; }
    }
}