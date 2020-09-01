namespace Machete.X12Schema.V5010
{
    using X12;


    public interface EA :
        X12Segment
    {
        Value<string> EquipmentAttributeCode { get; }
        
        Value<C001> CompositeUnitOfMeasure { get; }
        
        Value<decimal> Quantity { get; }
    }
}