namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class V3Map :
        X12SegmentMap<V3, X12Entity>
    {
        public V3Map()
        {
            Id = "V3";
            Name = "Vessel Schedule";
            
            Value(x => x.CurrentPortOfLoading, 1, x => x.MinLength(2).MaxLength(24).IsRequired());
            Value(x => x.Date1, 2, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.NextPortOfLoading, 3, x => x.MinLength(2).MaxLength(24));
            Value(x => x.Date2, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
        }
    }
}