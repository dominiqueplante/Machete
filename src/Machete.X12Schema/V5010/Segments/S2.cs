namespace Machete.X12Schema.V5010
{
    using X12;


    public interface S2 :
        X12Segment
    {
        Value<int> StopSequenceNumber { get; }
        
        Value<string> AddressInformation1 { get; }
        
        Value<string> AddressInformation2 { get; }
    }
}