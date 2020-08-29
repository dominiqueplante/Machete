namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface G88 :
        X12Segment
    {
        Value<DateTime> PhysicalDeliveryOrReturnDate { get; }
        
        Value<DateTime> ProductOwnershipTransferDate { get; }
        
        Value<string> PurchaseOrderNumber { get; }
        
        Value<DateTime> PurchaseOrderDate { get; }
        
        Value<string> ReceiverLocationNumber { get; }
    }
}