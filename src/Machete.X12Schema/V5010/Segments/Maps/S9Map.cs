namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class S9Map :
        X12SegmentMap<S9, X12Entity>
    {
        public S9Map()
        {
            Id = "S9";
            Name = "Stop-off Station";
            
            Value(x => x.StopSequenceNumber, 1, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.StandardPointLocationCode, 2, x => x.MinLength(6).MaxLength(9));
            Value(x => x.CityName, 3, x => x.MinLength(2).MaxLength(30).IsRequired());
            Value(x => x.StateOrProvinceCode, 4, x => x.FixedLength(2).IsRequired());
            Value(x => x.CountryCode, 5, x => x.MinLength(2).MaxLength(3));
            Value(x => x.StopReasonCode, 6, x => x.FixedLength(2).IsRequired());
            Value(x => x.LocationQualifier, 7, x => x.MinLength(1).MaxLength(2));
            Value(x => x.LocationIdentifier, 8, x => x.MinLength(1).MaxLength(30));
        }
    }
}