namespace Machete.X12Schema.V5010
{
    using X12;


    public interface N12 :
        X12Segment
    {
        Value<string> FuelType { get; }
        
        Value<C001> CompositeUnitOfMeasure { get; }
    }
}