namespace Machete.X12Schema.V5010
{
    using X12;


    public interface BCT :
        X12Segment
    {
        Value<string> CatalogPurposeCode { get; }
        
        Value<string> CatalogNumber1 { get; }
        
        Value<string> CatalogVersionNumber1 { get; }
        
        Value<string> CatalogRevisionNumber1 { get; }
        
        Value<string> UnitOrBasisForMeasurementCode { get; }
        
        Value<string> CatalogNumber2 { get; }
        
        Value<string> CatalogVersionNumber2 { get; }
        
        Value<string> CatalogRevisionNumber2 { get; }
        
        Value<string> Description { get; }
        
        Value<string> TransactionSetPurpose { get; }
    }
}