namespace Machete.X12Schema.V5010
{
    using X12;


    public interface IM :
        X12Segment
    {
        Value<string> WaterMovementCode { get; }
        
        Value<string> SpecialHandlingCode { get; }
        
        Value<string> InlandTransportationCode { get; }
    }
}