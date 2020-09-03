namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class T1Map :
        X12SegmentMap<T1, X12Entity>
    {
        public T1Map()
        {
            Id = "T1";
            Name = "Stop-off Station";
            
            Value(x => x.AssignedNumber, 1, x => x.MinLength(1).MaxLength(6).IsRequired());
            Value(x => x.WaybillNumber, 2, x => x.MinLength(1).MaxLength(6));
            Value(x => x.Date, 3, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.LongDate;
            });
            Value(x => x.StandardCarrierAlphaCode, 4, x => x.MinLength(2).MaxLength(4));
            Value(x => x.CityName, 5, x => x.MinLength(2).MaxLength(30));
            Value(x => x.StateOrProvinceCode, 6, x => x.FixedLength(2));
            Value(x => x.StandardPointLocationCode, 7, x => x.MinLength(6).MaxLength(9));
            Value(x => x.TransitRegistrationNumber, 8, x => x.MinLength(1).MaxLength(6));
            Value(x => x.TransitLevelCode, 9, x => x.MinLength(1).MaxLength(3));
            Value(x => x.ReferenceIdentifierQualifier, 10, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 11, x => x.MinLength(1).MaxLength(50));
        }
    }
}