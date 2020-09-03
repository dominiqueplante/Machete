namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T6 :
        X12Segment
    {
        Value<int> AssignedNumber { get; }
        
        Value<decimal> FreightRate1 { get; }
        
        Value<string> RateOrValueQualifier1 { get; }
        
        Value<string> CityName1 { get; }
        
        Value<decimal> FreightRate2 { get; }
        
        Value<string> RateOrValueQualifier2 { get; }
        
        Value<string> CityName2 { get; }
    }
}