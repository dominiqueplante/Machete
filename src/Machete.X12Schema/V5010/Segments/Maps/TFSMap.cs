namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class TFSMap :
        X12SegmentMap<TFS, X12Entity>
    {
        public TFSMap()
        {
            Id = "TFS";
            Name = "Tax Form";

            Value(x => x.ReferenceIdentificationQualifier1, 1, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification2, 2, x => x.MinLength(1).MaxLength(50).IsRequired());
            Value(x => x.ReferenceIdentificationQualifier3, 3, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification4, 4, x => x.MinLength(1).MaxLength(50));
            Value(x => x.IdentificationCodeQualifier, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.IdentificationCode, 6, x => x.MinLength(2).MaxLength(80));
            Value(x => x.Date, 7, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.LongDate;
            });
            Value(x => x.NameCodeIdentifier, 8, x => x.MinLength(1).MaxLength(4));
        }
    }
}