namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class G23Map :
        X12SegmentMap<G23, X12Entity>
    {
        public G23Map()
        {
            Id = "G23";
            Name = "Terms of Sale";
            
            Value(x => x.TermsTypeCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.TermsBasisDateCode, 2, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.TermsStartDate, 3, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.TermsDueDateQualifier, 4, x => x.FixedLength(2));
            Value(x => x.TermsDiscountPercent, 5, x => x.MinLength(1).MaxLength(6));
            Value(x => x.TermsDiscountDueDate, 6, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.TermsDiscountDaysDue, 7, x => x.MinLength(1).MaxLength(3));
            Value(x => x.TermsNetDueDate, 8, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.TermsNetDays, 9, x => x.MinLength(1).MaxLength(3));
            Value(x => x.TermsDiscountAmount, 10, x => x.MinLength(1).MaxLength(10));
            Value(x => x.DiscountedAmountDue, 11, x => x.MinLength(1).MaxLength(10));
            Value(x => x.AmountSubjectToTermsDiscount, 12, x => x.MinLength(1).MaxLength(10));
            Value(x => x.InstallmentTotalInvoiceAmountDue, 13, x => x.MinLength(1).MaxLength(10));
            Value(x => x.PercentOfInvoicePayable, 14, x => x.MinLength(1).MaxLength(5));
            Value(x => x.FreeformMessage, 15, x => x.MinLength(1).MaxLength(60));
            Value(x => x.InstallmentGroupIndicator, 16, x => x.FixedLength(2));
        }
    }
}