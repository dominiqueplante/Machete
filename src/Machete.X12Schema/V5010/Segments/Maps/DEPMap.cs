namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class DEPMap :
        X12SegmentMap<DEP, X12Entity>
    {
        public DEPMap()
        {
            Id = "DEP";
            Name = "Deposit";
            
            Value(x => x.ReferenceIdentification1, 1, x => x.MinLength(1).MaxLength(50).IsRequired());
            Value(x => x.Date, 2, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.LongDate;
            });
            Value(x => x.Time, 3, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.ReferenceIdentification2, 4, x => x.MinLength(1).MaxLength(50));
            Value(x => x.DepositoryFinancialInstitutionIdentificationNumberQualifier, 5, x => x.FixedLength(2).IsRequired());
            Value(x => x.DepositoryFinancialInstitutionIdentificationNumber, 6, x => x.MinLength(3).MaxLength(12).IsRequired());
            Value(x => x.AccountNumberQualifier, 7, x => x.MinLength(1).MaxLength(3));
            Value(x => x.AccountNumber, 8, x => x.MinLength(1).MaxLength(35));
        }
    }
}