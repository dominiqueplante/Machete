namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class B2Map :
        X12SegmentMap<B2, X12Entity>
    {
        public B2Map()
        {
            Id = "B2";
            Name = "Beginning Segment for Shipment Information Transaction";
            
            Value(x => x.TariffServiceCode, 1, x => x.FixedLength(2));
            Value(x => x.StandardCarrierAlphaCode, 2, x => x.MinLength(2).MaxLength(4));
            Value(x => x.StandardPointLocationCode, 3, x => x.MinLength(6).MaxLength(9));
            Value(x => x.ShipmentIdentificationNumber, 4, x => x.MinLength(1).MaxLength(30));
            Value(x => x.WeightUnitCode, 5, x => x.FixedLength(1));
            Value(x => x.ShipmentMethodOfPayment, 6, x => x.FixedLength(2));
            Value(x => x.ShipmentQualifier, 7, x => x.FixedLength(1));
            Value(x => x.TotalEquipment, 8, x => x.MinLength(1).MaxLength(3));
            Value(x => x.ShipmentWeightCode, 9, x => x.FixedLength(1));
            Value(x => x.CustomsDocumentationHandlingCode, 10, x => x.FixedLength(2));
            Value(x => x.TransportationTermsCode, 11, x => x.FixedLength(3));
            Value(x => x.PaymentMethodCode, 12, x => x.FixedLength(3));
        }
    }
}