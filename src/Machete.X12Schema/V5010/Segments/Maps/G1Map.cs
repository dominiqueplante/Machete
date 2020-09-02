namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G1Map :
        X12SegmentMap<G1, X12Entity>
    {
        public G1Map()
        {
            Id = "G1";
            Name = "Shipment Type Information";
            
            Value(x => x.ShipmentTypeCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.SpecialIndicatorCode1, 2, x => x.FixedLength(1));
            Value(x => x.SpecialIndicatorCode2, 3, x => x.FixedLength(1));
        }
    }
}