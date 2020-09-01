namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class Y4Map :
        X12SegmentMap<Y4, X12Entity>
    {
        public Y4Map()
        {
            Id = "Y4";
            Name = "Container Release";
            
            Value(x => x.BookingNumber1, 1, x => x.MinLength(1).MaxLength(17));
            Value(x => x.BookingNumber2, 2, x => x.MinLength(1).MaxLength(17));
            Value(x => x.Date, 3, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.StandardPointLocationCode, 4, x => x.MinLength(6).MaxLength(9));
            Value(x => x.NumberOfContainers, 5, x => x.MinLength(1).MaxLength(4));
            Value(x => x.EquipmentType, 6, x => x.FixedLength(4));
            Value(x => x.StandardCarrierAlphaCode, 7, x => x.MinLength(2).MaxLength(4));
            Value(x => x.LocationQualifier, 8, x => x.MinLength(1).MaxLength(2));
            Value(x => x.LocationIdentifier, 9, x => x.MinLength(1).MaxLength(30));
            Value(x => x.TypeOfServiceCode, 10, x => x.FixedLength(2));
        }
    }
}