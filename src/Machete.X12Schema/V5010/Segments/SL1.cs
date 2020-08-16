namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface SL1 :
        X12Segment
    {
        Value<string> ServiceLevelCode1 { get; }
        
        Value<string> TariffNumber { get; }
        
        Value<string> CommodityCode { get; }
        
        Value<string> Scale { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> ServiceLevelCode2 { get; }
        
        Value<string> ShipmentMethodOfPayment { get; }
        
        Value<string> DataSourceCode { get; }
        
        Value<string> InternationalOrDomesticCode { get; }
    }
}