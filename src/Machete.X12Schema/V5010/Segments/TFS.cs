namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface TFS :
        X12Segment
    {
        Value<string> ReferenceIdentificationQualifier1 { get; }

        Value<string> ReferenceIdentification2 { get; }

        Value<string> ReferenceIdentificationQualifier3 { get; }

        Value<string> ReferenceIdentification4 { get; }

        Value<string> IdentificationCodeQualifier { get; }

        Value<string> IdentificationCode { get; }

        Value<DateTime> Date { get; }

        Value<string> NameCodeIdentifier { get; }
    }
}