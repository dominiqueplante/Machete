namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class H6Map :
        X12SegmentMap<H6, X12Entity>
    {
        public H6Map()
        {
            Id = "H6";
            Name = "Special Services";
            
            Value(x => x.SpecialServicesCode1, 1, x => x.MinLength(2).MaxLength(10));
            Value(x => x.SpecialServicesCode2, 2, x => x.MinLength(2).MaxLength(10));
            Value(x => x.QuantityOfPalletsShipped, 3, x => x.MinLength(1).MaxLength(3));
            Value(x => x.PalletExchangeCode, 4, x => x.FixedLength(1));
            Value(x => x.Weight, 5, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightUnitCode, 6, x => x.FixedLength(1));
            Value(x => x.PickupOrDeliveryCode, 7, x => x.MinLength(1).MaxLength(2));
        }
    }
}