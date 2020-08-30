namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface BTI :
        X12Segment
    {
        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }

        Value<string> IdentifierCodeQualifier1 { get; }

        Value<string> IdentifierCode1 { get; }

        Value<DateTime> Date { get; }

        Value<string> NameCodeIdentifier { get; }

        Value<string> IdentifierCodeQualifier2 { get; }

        Value<string> IdentifierCode2 { get; }

        Value<string> IdentifierCodeQualifier3 { get; }

        Value<string> IdentifierCode3 { get; }

        Value<string> IdentifierCodeQualifier4 { get; }

        Value<string> IdentifierCode4 { get; }

        Value<string> TransactionSetPurposeCode { get; }

        Value<string> TransactionTypeCode { get; }
    }
}