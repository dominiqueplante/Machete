namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class MS1Map :
        X12SegmentMap<MS1, X12Entity>
    {
        public MS1Map()
        {
            Id = "MS1";
            Name = "Equipment, Shipment, or Real Property Location";
            
            Value(x => x.CityName, 1, x => x.MinLength(2).MaxLength(30));
            Value(x => x.StateOrProvinceCode, 2, x => x.FixedLength(2));
            Value(x => x.CountryCode, 3, x => x.MinLength(2).MaxLength(3));
            Value(x => x.LongitudeCode, 4, x => x.FixedLength(7));
            Value(x => x.LatitudeCode, 5, x => x.FixedLength(7));
            Value(x => x.DirectionIdentifierCode1, 6, x => x.FixedLength(1));
            Value(x => x.DirectionIdentifierCode2, 7, x => x.FixedLength(1));
            Value(x => x.PostalCode, 8, x => x.MinLength(3).MaxLength(15));
        }
    }
}