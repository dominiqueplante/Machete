namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class SUPMap :
        X12SegmentMap<SUP, X12Entity>
    {
        public SUPMap()
        {
            Id = "SUP";
            Name = "Supplementary Information";
            
            Value(x => x.SupplementaryInformationQualifier, 1, x => x.FixedLength(3).IsRequired());
            Value(x => x.CertificationOrClauseCode, 2, x => x.MinLength(2).MaxLength(4));
            Value(x => x.FreeformMessage, 3, x => x.MinLength(1).MaxLength(60));
            Value(x => x.PrintOptionCode, 4, x => x.FixedLength(2));
        }
    }
}