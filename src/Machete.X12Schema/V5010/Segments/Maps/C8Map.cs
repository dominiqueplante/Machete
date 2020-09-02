namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class C8Map :
        X12SegmentMap<C8, X12Entity>
    {
        public C8Map()
        {
            Id = "C8";
            Name = "Certifications and Clauses";
            
            Value(x => x.LadingLineItemNumber, 1, x => x.MinLength(1).MaxLength(3));
            Value(x => x.CertificationOrClauseCode, 2, x => x.MinLength(2).MaxLength(4));
            Value(x => x.CertificationOrClauseText, 3, x => x.MinLength(2).MaxLength(60));
            Value(x => x.ShipperExportDeclarationRequirements, 4, x => x.MinLength(1).MaxLength(2));
        }
    }
}