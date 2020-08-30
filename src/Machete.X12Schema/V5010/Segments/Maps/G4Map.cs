namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class G4Map :
        X12SegmentMap<G4, X12Entity>
    {
        public G4Map()
        {
            Id = "G4";
            Name = "Scale Identification";
            
            Value(x => x.CityName, 1, x => x.MinLength(2).MaxLength(30).IsRequired());
            Value(x => x.StateOrProvinceCode, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.Name, 3, x => x.MinLength(1).MaxLength(60));
            Value(x => x.Date, 4, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.LongDate;
            });
            Value(x => x.Time, 5, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.ScaleTypeCode, 6, x => x.FixedLength(1));
        }
    }
}