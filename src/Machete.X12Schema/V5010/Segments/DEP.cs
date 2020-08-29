namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface DEP :
        X12Segment
    {
        Value<string> ReferenceIdentification1 { get; }

        Value<DateTime> Date { get; }

        Value<TimeSpan> Time { get; }

        Value<string> ReferenceIdentification2 { get; }

        Value<string> DepositoryFinancialInstitutionIdentificationNumberQualifier { get; }

        Value<string> DepositoryFinancialInstitutionIdentificationNumber { get; }

        Value<string> AccountNumberQualifier { get; }

        Value<string> AccountNumber { get; }
    }
}