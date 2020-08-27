namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface G26 :
        X12Segment
    {
        Value<string> PriceConditionCode { get; }
        
        Value<string> DateQualifier { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> QuantityBasis { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> UnitOrBasisForMeasurementCode { get; }
    }
}