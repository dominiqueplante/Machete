namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T6Map :
        X12SegmentMap<T6, X12Entity>
    {
        public T6Map()
        {
            Id = "T6";
            Name = "Transit Inbound Rates";
            
            Value(x => x.AssignedNumber, 1, x => x.MinLength(1).MaxLength(6).IsRequired());
            Value(x => x.FreightRate1, 2, x => x.MinLength(1).MaxLength(9));
            Value(x => x.RateOrValueQualifier1, 3, x => x.FixedLength(2));
            Value(x => x.CityName1, 4, x => x.MinLength(2).MaxLength(30));
            Value(x => x.FreightRate2, 5, x => x.MinLength(1).MaxLength(9));
            Value(x => x.RateOrValueQualifier2, 6, x => x.FixedLength(2));
            Value(x => x.CityName2, 7, x => x.MinLength(2).MaxLength(30));
        }
    }
}