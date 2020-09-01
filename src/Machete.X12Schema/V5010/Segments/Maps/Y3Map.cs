namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class Y3Map :
        X12SegmentMap<Y3, X12Entity>
    {
        public Y3Map()
        {
            Id = "Y3";
            Name = "Space Confirmation";
            
            Value(x => x.BookingNumber, 1, x => x.MinLength(1).MaxLength(17).IsRequired());
            Value(x => x.StandardCarrierAlphaCode, 2, x => x.MinLength(2).MaxLength(4));
            Value(x => x.Date1, 3, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date2, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.StandardPointLocationCode, 5, x => x.MinLength(6).MaxLength(9));
            Value(x => x.PierName, 6, x => x.MinLength(2).MaxLength(14));
            Value(x => x.Date3, 7, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Time, 8, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.TransportationMethodCode, 9, x => x.MinLength(1).MaxLength(2));
            Value(x => x.TariffServiceCode, 10, x => x.FixedLength(2));
            Value(x => x.TimeCode, 11, x => x.FixedLength(2));
        }
    }
}