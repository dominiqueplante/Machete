namespace Machete.X12Schema.V5010
{
    using X12;


    public interface CMC :
        X12Segment
    {
        Value<string> CommodityCode { get; }
        
        Value<string> FreightClassCode { get; }
    }
}