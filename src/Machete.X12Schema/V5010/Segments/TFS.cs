namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface TFS :
        X12Segment
    {
        Value<string> ReferenceIdentificationQualifier01 { get; }

        Value<string> ReferenceIdentification02 { get; }

        Value<string> ReferenceIdentificationQualifier03 { get; }

        Value<string> ReferenceIdentification04 { get; }

        Value<string> IdentificationCodeQualifier { get; }

        Value<string> IdentificationCode { get; }

        Value<DateTime> Date { get; }

        Value<string> NameCodeIdentifier { get; }
    }
}