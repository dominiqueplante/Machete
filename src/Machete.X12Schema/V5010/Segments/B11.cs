namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface B11 :
        X12Segment
    {
        Value<string> IdentificationCodeQualifier { get; }
        
        Value<string> IdentificationCode { get; }
        
        Value<DateTime> Date { get; }

        Value<string> UnitOrBasisForMeasurementCode { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> AmountQualifierCode { get; }
        
        Value<decimal> MonetaryAmount { get; }
        
        Value<string> ItemDescriptionType { get; }
        
        Value<string> Description { get; }
        
        Value<string> ServiceLevelCode { get; }
        
        Value<string> ReportTransmissionCode { get; }
    }
}