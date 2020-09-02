namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G1 :
        X12Segment
    {
        Value<string> ShipmentTypeCode { get; }
        
        Value<string> SpecialIndicatorCode1 { get; }
        
        Value<string> SpecialIndicatorCode2 { get; }
    }
}