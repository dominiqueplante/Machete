namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L8Map :
        X12SegmentMap<L8, X12Entity>
    {
        public L8Map()
        {
            Id = "L8";
            Name = "Route Code Identification";
            
            Value(x => x.BilledOrRatedAsQuantity, 1, x => x.MinLength(1).MaxLength(11));
            Value(x => x.BilledOrRatedAsQualifier, 2, x => x.FixedLength(2));
            Value(x => x.Weight, 3, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightUnitCode, 4, x => x.FixedLength(1));
            Value(x => x.WeightQualifier, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.FreightRate, 6, x => x.MinLength(1).MaxLength(9));
            Value(x => x.RateOrValueQualifier, 7, x => x.FixedLength(2));
            Value(x => x.Amount, 8, x => x.MinLength(1).MaxLength(15));
            Value(x => x.SpecialChargeOrAllowanceCode, 9, x => x.FixedLength(3));
            Value(x => x.SpecialChargeDescription, 10, x => x.MinLength(2).MaxLength(25));
            Value(x => x.ChargeMethodOfPayment, 11, x => x.FixedLength(3));
        }
    }
}