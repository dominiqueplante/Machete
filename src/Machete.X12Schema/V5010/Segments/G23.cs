namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface G23 :
        X12Segment
    {
        Value<string> TermsTypeCode { get; }
        
        Value<string> TermsBasisDateCode { get; }
        
        Value<DateTime> TermsStartDate { get; }
        
        Value<string> TermsDueDateQualifier { get; }
        
        Value<decimal> TermsDiscountPercent { get; }
        
        Value<DateTime> TermsDiscountDueDate { get; }
        
        Value<int> TermsDiscountDaysDue { get; }
        
        Value<DateTime> TermsNetDueDate { get; }
        
        Value<int> TermsNetDays { get; }
        
        Value<decimal> TermsDiscountAmount { get; }
        
        Value<decimal> DiscountedAmountDue { get; }
        
        Value<decimal> AmountSubjectToTermsDiscount { get; }
        
        Value<decimal> InstallmentTotalInvoiceAmountDue { get; }
        
        Value<decimal> PercentOfInvoicePayable { get; }
        
        Value<string> FreeformMessage { get; }
        
        Value<int> InstallmentGroupIndicator { get; }
    }
}