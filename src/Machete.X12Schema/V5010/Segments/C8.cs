namespace Machete.X12Schema.V5010
{
    using X12;


    public interface C8 :
        X12Segment
    {
        Value<string> LadingLineItemNumber { get; }
        
        Value<string> CertificationOrClauseCode { get; }
        
        Value<string> CertificationOrClauseText { get; }
        
        Value<string> ShipperExportDeclarationRequirements { get; }
    }
}