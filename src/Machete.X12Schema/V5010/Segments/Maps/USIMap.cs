namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class USIMap :
        X12SegmentMap<USI, X12Entity>
    {
        public USIMap()
        {
            Id = "USI";
            Name = "Unitized Shipment Information";
            
            Value(x => x.Quantity, 1, x => x.MinLength(2).MaxLength(15).IsRequired());
            Value(x => x.PackagingFormCode, 2, x => x.FixedLength(3).IsRequired());
            Value(x => x.YesNoConditionOrResponseCode2, 3, x => x.FixedLength(2));
        }
    }
}