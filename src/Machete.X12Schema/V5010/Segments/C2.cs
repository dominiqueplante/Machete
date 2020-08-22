namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface C2 :
        X12Segment
    {
        Value<string> BankClientCode { get; }
        
        Value<string> IdentificationCodeQualifier { get; }
        
        Value<string> IdentificationCode { get; }
        
        Value<string> ClientBankNumber { get; }
        
        Value<string> BankAccountNumber { get; }
        
        Value<string> PaymentMethodTypeCode { get; }
        
        Value<DateTime> Date { get; }
    }
}