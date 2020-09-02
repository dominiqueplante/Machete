namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class M0Map :
        X12SegmentMap<M0, X12Entity>
    {
        public M0Map()
        {
            Id = "M0";
            Name = "Letter of Credit Reference";
            
            Value(x => x.LetterOfCreditNumber, 1, x => x.MinLength(2).MaxLength(40).IsRequired());
            Value(x => x.Date1, 2, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date2, 3, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date3, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
        }
    }
}