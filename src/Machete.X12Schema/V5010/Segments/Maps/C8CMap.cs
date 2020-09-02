namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class C8CMap :
        X12SegmentMap<C8C, X12Entity>
    {
        public C8CMap()
        {
            Id = "C8C";
            Name = "Certifications Clauses Continuation";
            
            Value(x => x.CertificationOrClauseText1, 1, x => x.MinLength(2).MaxLength(60).IsRequired());
            Value(x => x.CertificationOrClauseText2, 2, x => x.MinLength(2).MaxLength(60));
            Value(x => x.CertificationOrClauseText3, 3, x => x.MinLength(2).MaxLength(60));
        }
    }
}