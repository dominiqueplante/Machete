namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T2Map :
        X12SegmentMap<T2, X12Entity>
    {
        public T2Map()
        {
            Id = "T2";
            Name = "Stop-off Station";
            
            Value(x => x.AssignedNumber, 1, x => x.MinLength(1).MaxLength(6).IsRequired());
            Value(x => x.LadingDescription, 2, x => x.MinLength(1).MaxLength(50));
            Value(x => x.Weight, 3, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightQualifier, 4, x => x.MinLength(1).MaxLength(2));
            Value(x => x.FreightRate1, 5, x => x.MinLength(1).MaxLength(9));
            Value(x => x.RateOrValueQualifier1, 6, x => x.FixedLength(2));
            Value(x => x.FreightRate2, 7, x => x.MinLength(1).MaxLength(9));
            Value(x => x.RateOrValueQualifier2, 8, x => x.FixedLength(2));
            Value(x => x.CityName1, 9, x => x.MinLength(2).MaxLength(30));
            Value(x => x.CityName2, 10, x => x.MinLength(2).MaxLength(30));
            Value(x => x.ThroughSurchargePercent, 11, x => x.MinLength(2).MaxLength(4));
            Value(x => x.PaidInSurchargePercent, 12, x => x.MinLength(2).MaxLength(4));
        }
    }
}