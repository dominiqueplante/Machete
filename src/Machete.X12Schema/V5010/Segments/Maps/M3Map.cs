namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class M3Map :
        X12SegmentMap<M3, X12Entity>
    {
        public M3Map()
        {
            Id = "M3";
            Name = "Release";
            
            Value(x => x.ReleaseCode, 1, x => x.FixedLength(1).IsRequired());
            Value(x => x.Date, 2, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Time, 3, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.TimeCode, 4, x => x.FixedLength(2));
        }
    }
}