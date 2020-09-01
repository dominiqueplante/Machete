namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class Y1Map :
        X12SegmentMap<Y1, X12Entity>
    {
        public Y1Map()
        {
            Id = "Y1";
            Name = "Space Reservation Request";
            
            Value(x => x.SailingOrFlightDateEstimated, 1, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.LongDate;
            });
            Value(x => x.Date, 2, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.LongDate;
            });
            Value(x => x.StandardCarrierAlphaCode, 3, x => x.MinLength(2).MaxLength(4));
            Value(x => x.TransportationMethodCode, 4, x => x.MinLength(1).MaxLength(2));
            Value(x => x.EntityIdentifierCode, 5, x => x.MinLength(2).MaxLength(3));
            Value(x => x.CityName, 6, x => x.MinLength(2).MaxLength(30));
            Value(x => x.StateOrProvinceCode, 7, x => x.FixedLength(2));
            Value(x => x.TariffServiceCode, 8, x => x.FixedLength(2));
            Value(x => x.DateOrTimeQualifier, 9, x => x.FixedLength(3));
        }
    }
}