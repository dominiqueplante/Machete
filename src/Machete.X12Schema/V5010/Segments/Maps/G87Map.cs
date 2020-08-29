namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G87Map :
        X12SegmentMap<G87, X12Entity>
    {
        public G87Map()
        {
            Id = "G87";
            Name = "Allowance or Charge";
            
            Value(x => x.InitiatorCode, 1, x => x.FixedLength(1).IsRequired());
            Value(x => x.CreditOrDebitFlagCode, 2, x => x.FixedLength(1).IsRequired());
            Value(x => x.SupplierDeliveryOrReturnNumber, 3, x => x.MinLength(1).MaxLength(22).IsRequired());
            Value(x => x.IntegrityCheckValue, 4, x => x.MinLength(1).MaxLength(12).IsRequired());
            Value(x => x.AdjustmentSequenceNumber, 5, x => x.FixedLength(1).IsRequired());
            Value(x => x.ReceiverDeliveryOrReturnNumber, 6, x => x.MinLength(1).MaxLength(22));
        }
    }
}