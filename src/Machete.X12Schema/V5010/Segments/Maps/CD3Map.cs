namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class CD3Map :
        X12SegmentMap<CD3, X12Entity>
    {
        public CD3Map()
        {
            Id = "CD3";
            Name = "Carton (Package) Detail";
            
            Value(x => x.WeightQualifier, 1, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Weight, 2, x => x.MinLength(1).MaxLength(10));
            Value(x => x.Zone, 3, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ServiceStandard, 4, x => x.MinLength(1).MaxLength(4));
            Value(x => x.ServiceLevelCode1, 5, x => x.FixedLength(2));
            Value(x => x.PickupDeliveryCode, 6, x => x.MinLength(1).MaxLength(2));
            Value(x => x.RateOrValueQualifier1, 7, x => x.FixedLength(2));
            Value(x => x.AmountCharged1, 8, x => x.MinLength(1).MaxLength(15));
            Value(x => x.RateOrValueQualifier2, 9, x => x.FixedLength(2));
            Value(x => x.AmountCharged2, 10, x => x.MinLength(1).MaxLength(15));
            Value(x => x.ServiceLevelCode2, 11, x => x.FixedLength(2));
            Value(x => x.ServiceLevelCode3, 12, x => x.FixedLength(2));
            Value(x => x.PaymentMethodCode, 13, x => x.FixedLength(3));
            Value(x => x.CountryCode, 14, x => x.MinLength(2).MaxLength(3));
        }
    }
}