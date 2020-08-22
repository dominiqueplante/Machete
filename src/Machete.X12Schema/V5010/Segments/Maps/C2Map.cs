namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class C2Map :
        X12SegmentMap<C2, X12Entity>
    {
        public C2Map()
        {
            Id = "C2";
            Name = "Bank ID";
            
            Value(x => x.BankClientCode, 1, x => x.FixedLength(1).IsRequired());
            Value(x => x.IdentificationCodeQualifier, 2, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.IdentificationCode, 3, x => x.MinLength(2).MaxLength(80).IsRequired());
            Value(x => x.ClientBankNumber, 4, x => x.MinLength(3).MaxLength(9));
            Value(x => x.BankAccountNumber, 5, x => x.MinLength(6).MaxLength(17));
            Value(x => x.PaymentMethodTypeCode, 6, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Date, 7, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
        }
    }
}