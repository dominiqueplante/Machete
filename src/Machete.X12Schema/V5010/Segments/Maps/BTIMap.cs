namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class BTIMap :
        X12SegmentMap<BTI, X12Entity>
    {
        public BTIMap()
        {
            Id = "BTI";
            Name = "Beginning Tax Information";

            Value(x => x.ReferenceIdentificationQualifier, 1, x=> x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 2, x=> x.MinLength(1).MaxLength(50).IsRequired());
            Value(x => x.IdentifierCodeQualifier03, 3, x=> x.MinLength(1).MaxLength(2));
            Value(x => x.IdentifierCode04, 4, x=> x.MinLength(2).MaxLength(80).IsRequired());
            Value(x => x.Date, 5, x=> x.FixedLength(8));
            Value(x => x.NameCodeIdentifier, 6, x=> x.MinLength(1).MaxLength(4));
            Value(x => x.IdentifierCodeQualifier07, 7, x=> x.MinLength(1).MaxLength(2));
            Value(x => x.IdentifierCode08, 8, x=> x.MinLength(2).MaxLength(80));
            Value(x => x.IdentifierCodeQualifier09, 9, x=> x.MinLength(1).MaxLength(2));
            Value(x => x.IdentifierCode10, 10, x=> x.MinLength(2).MaxLength(80));
            Value(x => x.IdentifierCodeQualifier11, 11, x=> x.MinLength(1).MaxLength(2));
            Value(x => x.IdentifierCode12, 12, x=> x.MinLength(2).MaxLength(80));
            Value(x => x.TransactionSetPurposeCode, 13, x=> x.FixedLength(2));
            Value(x => x.TransactionTypeCode, 14, x=> x.FixedLength(2));
        }
    }
}