namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class G47Map :
        X12SegmentMap<G47, X12Entity>
    {
        public G47Map()
        {
            Id = "G47";
            Name = "Statement Identification";
            
            Value(x => x.Date, 1, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.StatementNumber, 2, x => x.MinLength(1).MaxLength(16).IsRequired());
        }
    }
}