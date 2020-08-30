namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class BTIMap :
        X12SegmentMap<BTI, X12Entity>
    {
        public BTIMap()
        {
            Id = "BTI";
            Name = "Beginning Tax Information";

            Value(x => x.ReferenceIdentificationQualifier, 1, x=> x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 2, x=> x.MinLength(1).MaxLength(50).IsRequired());
            Value(x => x.IdentifierCodeQualifier1, 3, x=> x.MinLength(1).MaxLength(2));
            Value(x => x.IdentifierCode1, 4, x=> x.MinLength(2).MaxLength(80).IsRequired());
            Value(x => x.Date, 5, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.LongDate;
            });
            Value(x => x.NameCodeIdentifier, 6, x=> x.MinLength(1).MaxLength(4));
            Value(x => x.IdentifierCodeQualifier2, 7, x=> x.MinLength(1).MaxLength(2));
            Value(x => x.IdentifierCode2, 8, x=> x.MinLength(2).MaxLength(80));
            Value(x => x.IdentifierCodeQualifier3, 9, x=> x.MinLength(1).MaxLength(2));
            Value(x => x.IdentifierCode3, 10, x=> x.MinLength(2).MaxLength(80));
            Value(x => x.IdentifierCodeQualifier4, 11, x=> x.MinLength(1).MaxLength(2));
            Value(x => x.IdentifierCode4, 12, x=> x.MinLength(2).MaxLength(80));
            Value(x => x.TransactionSetPurposeCode, 13, x=> x.FixedLength(2));
            Value(x => x.TransactionTypeCode, 14, x=> x.FixedLength(2));
        }
    }
}