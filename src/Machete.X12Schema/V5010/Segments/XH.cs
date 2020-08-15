namespace Machete.X12Schema.V5010
{
    using X12;


    public interface XH :
        X12Segment
    {
        Value<string> CurrencyCode { get; }
        
        Value<string> RelatedCompanyIndicationCode { get; }
        
        Value<string> SpecialChargeOrAllowanceCode { get; }
        
        Value<decimal> Amount { get; }
        
        Value<string> Block20Code { get; }
        
        Value<decimal> ChemicalAnalysisPercentage { get; }
        
        Value<decimal> UnitPrice { get; }
    }
}