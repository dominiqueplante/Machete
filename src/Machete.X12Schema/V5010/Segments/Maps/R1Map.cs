namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class R1Map :
        X12SegmentMap<R1, X12Entity>
    {
        public R1Map()
        {
            Id = "R1";
            Name = "Route Information (Air)";
            
            Value(x => x.StandardCarrierAlphaCode1, 1, x => x.MinLength(2).MaxLength(4));
            Value(x => x.StandardCarrierAlphaCode2, 2, x => x.MinLength(2).MaxLength(4));
            Value(x => x.AirportCode1, 3, x => x.MinLength(3).MaxLength(5).IsRequired());
            Value(x => x.AirCarrierCode1, 4, x => x.FixedLength(3).IsRequired());
            Value(x => x.AirportCode2, 5, x => x.MinLength(3).MaxLength(5).IsRequired());
            Value(x => x.AirCarrierCode2, 6, x => x.FixedLength(3));
            Value(x => x.AirportCode3, 7, x => x.MinLength(3).MaxLength(5));
            Value(x => x.AirCarrierCode3, 8, x => x.FixedLength(3));
            Value(x => x.AirportCode4, 9, x => x.MinLength(3).MaxLength(5));
            Value(x => x.AirCarrierCode4, 10, x => x.FixedLength(3));
            Value(x => x.AirportCode5, 11, x => x.MinLength(3).MaxLength(5));
            Value(x => x.AirCarrierCode5, 12, x => x.FixedLength(3));
            Value(x => x.AirportCode6, 13, x => x.MinLength(3).MaxLength(5));
        }
    }
}