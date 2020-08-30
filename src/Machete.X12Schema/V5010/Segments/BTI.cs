namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface BTI :
        X12Segment
    {
        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }

        Value<string> IdentifierCodeQualifier03 { get; }

        Value<string> IdentifierCode04 { get; }

        Value<DateTime> Date { get; }

        Value<string> NameCodeIdentifier { get; }

        Value<string> IdentifierCodeQualifier07 { get; }

        Value<string> IdentifierCode08 { get; }

        Value<string> IdentifierCodeQualifier09 { get; }

        Value<string> IdentifierCode10 { get; }

        Value<string> IdentifierCodeQualifier11 { get; }

        Value<string> IdentifierCode12 { get; }

        Value<string> TransactionSetPurposeCode { get; }

        Value<string> TransactionTypeCode { get; }
    }
}