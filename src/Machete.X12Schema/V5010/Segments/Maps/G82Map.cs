namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class G82Map :
        X12SegmentMap<G82, X12Entity>
    {
        public G82Map()
        {
            Id = "G82";
            Name = "Allowance or Charge";
            
            Value(x => x.CreditOrDebitFlagCode, 1, x => x.FixedLength(1).IsRequired());
            Value(x => x.SupplierDeliveryOrReturnNumber, 2, x => x.MinLength(1).MaxLength(22).IsRequired());
            Value(x => x.DunAndBradstreetNumber1, 3, x => x.FixedLength(9).IsRequired());
            Value(x => x.ReceiverLocationNumber, 4, x => x.MinLength(1).MaxLength(6).IsRequired());
            Value(x => x.DunAndBradstreetNumber2, 5, x => x.FixedLength(9).IsRequired());
            Value(x => x.SupplierLocationNumber, 6, x => x.MinLength(1).MaxLength(6).IsRequired());
            Value(x => x.PhysicalDeliveryOrReturnDate, 7, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ProductOwnershipTransferDate, 8, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.PurchaseOrderNumber, 9, x => x.MinLength(1).MaxLength(22));
            Value(x => x.PurchaseOrderDate, 10, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ShipmentMethodOfPayment, 11, x => x.FixedLength(2));
            Value(x => x.CashOnDeliveryMethodOfPaymentCode, 12, x => x.FixedLength(1));
        }
    }
}