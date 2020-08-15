namespace Machete.X12Schema.V5010
{
    using X12;


    public interface M7 :
        X12Segment
    {
        Value<string> SealNumber1 { get; }
        
        Value<string> SealNumber2 { get; }
        
        Value<string> SealNumber3 { get; }
        
        Value<string> SealNumber4 { get; }
        
        Value<string> EntityIdentifierCode { get; }
    }
}