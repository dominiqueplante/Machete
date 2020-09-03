namespace Machete.X12Schema.V5010
{
    using X12;


    public interface H5 :
        X12Segment
    {
        Value<string> CarServiceOrderCode { get; }
        
        Value<string> CityName { get; }
        
        Value<string> StateOrProvinceCode { get; }
    }
}