namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface P2 :
        X12Segment
    {
        Value<string> PickupOrDeliveryCode { get; }
        
        Value<DateTime> DeliveryDate { get; }
        
        Value<int> DateOrTimeQualifier { get; }
    }
}