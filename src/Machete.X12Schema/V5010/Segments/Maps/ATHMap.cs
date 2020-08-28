namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class ATHMap :
        X12SegmentMap<ATH, X12Entity>
    {
        public ATHMap()
        {
            Id = "ATH";
            Name = "Resource Authorization";
            
            Value(x => x.ResourceAuthorizationCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.Date1, 2, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Quantity1, 3, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Quantity2, 4, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Date2, 5, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
        }
    }
}