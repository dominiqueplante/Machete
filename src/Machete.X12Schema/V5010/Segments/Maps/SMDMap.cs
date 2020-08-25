namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class SMDMap :
        X12SegmentMap<SMD, X12Entity>
    {
        public SMDMap()
        {
            Id = "SMD";
            Name = "Consolidated Shipment Manifest Data";
            
            Value(x => x.ServiceLevelCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.ShipmentMethodOfPayment, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.PickupOrDeliveryCode, 3, x => x.MinLength(1).MaxLength(2));
        }
    }
}