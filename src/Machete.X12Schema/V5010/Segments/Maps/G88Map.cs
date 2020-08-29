namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class G88Map :
        X12SegmentMap<G88, X12Entity>
    {
        public G88Map()
        {
            Id = "G88";
            Name = "Delivery/Return Identification Adjustment";
            
            Value(x => x.PhysicalDeliveryOrReturnDate, 1, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ProductOwnershipTransferDate, 2, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.PurchaseOrderNumber, 3, x => x.MinLength(1).MaxLength(22));
            Value(x => x.PurchaseOrderDate, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ReceiverLocationNumber, 5, x => x.MinLength(1).MaxLength(6));
        }
    }
}