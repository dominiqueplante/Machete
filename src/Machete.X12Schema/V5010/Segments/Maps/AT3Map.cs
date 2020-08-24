namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class AT3Map :
        X12SegmentMap<AT3, X12Entity>
    {
        public AT3Map()
        {
            Id = "AT3";
            Name = "Bill of Lading Rates and Charges";
            
            Value(x => x.AmountCharge, 1, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.FreightRateQualifier, 2, x => x.FixedLength(2));
            Value(x => x.FreightRate, 3, x => x.MinLength(1).MaxLength(9));
            Value(x => x.RateAsQualifier, 4, x => x.FixedLength(2));
            Value(x => x.Quantity, 5, x => x.MinLength(1).MaxLength(15));
            Value(x => x.BillOfLadingChargeCode, 6, x => x.FixedLength(3));
            Value(x => x.PercentageAsDecimal, 7, x => x.MinLength(1).MaxLength(10));
        }
    }
}