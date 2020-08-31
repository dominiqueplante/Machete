namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class ACSMap :
        X12SegmentMap<ACS, X12Entity>
    {
        public ACSMap()
        {
            Id = "ACS";
            Name = "Ancillary Charges";
            
            Value(x => x.Amount, 1, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.SpecialChargeOrAllowanceCode, 2, x => x.FixedLength(1).IsRequired());
            Value(x => x.Description, 3, x => x.MinLength(1).MaxLength(80));
            Value(x => x.ShipmentMethodOfPayment, 4, x => x.FixedLength(1));
        }
    }
}