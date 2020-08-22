namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L4 :
        X12Segment
    {
        Value<decimal> Length { get; }
        
        Value<decimal> Width { get; }
        
        Value<decimal> Height { get; }
        
        Value<string> MeasurementUitQualifier { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> IndustryCode { get; }
    }
}