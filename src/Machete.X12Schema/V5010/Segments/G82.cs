namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface G82 :
        X12Segment
    {
        Value<string> CreditOrDebitFlagCode { get; }
        
        Value<string> SupplierDeliveryOrReturnNumber { get; }
        
        Value<string> DunAndBradstreetNumber1 { get; }
        
        Value<string> ReceiverLocationNumber { get; }
        
        Value<string> DunAndBradstreetNumber2 { get; }
        
        Value<string> SupplierLocationNumber { get; }
        
        Value<DateTime> PhysicalDeliveryOrReturnDate { get; }
        
        Value<DateTime> ProductOwnershipTransferDate { get; }
        
        Value<string> PurchaseOrderNumber { get; }
        
        Value<DateTime> PurchaseOrderDate { get; }
        
        Value<decimal> ShipmentMethodOfPayment { get; }
        
        Value<string> CashOnDeliveryMethodOfPaymentCode { get; }
    }
}