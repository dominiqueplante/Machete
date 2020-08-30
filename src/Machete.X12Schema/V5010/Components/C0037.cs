namespace Machete.X12Schema.V5010
{
    using X12;


    public interface C0037 :
        X12Component
    {
        Value<string> TaxInformationIdentificationNumber { get; }

        Value<string> ApplicationErrorConditionCode { get; }
    }
}