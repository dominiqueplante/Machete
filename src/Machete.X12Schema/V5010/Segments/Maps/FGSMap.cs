namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class FGSMap :
        X12SegmentMap<FGS, X12Entity>
    {
        public FGSMap()
        {
            Id = "FGS";
            Name = "Form Group";

            Value(x => x.AssignedIdentifier, 1, x => x.MinLength(1).MaxLength(20));
            Value(x => x.ReferenceIdentificationQualifier, 1, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 2, x => x.MinLength(1).MaxLength(50));
        }
    }
}