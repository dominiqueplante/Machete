namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class H2Map :
        X12SegmentMap<H2, X12Entity>
    {
        public H2Map()
        {
            Id = "H2";
            Name = "Additional Hazardous Material Description";
            
            Value(x => x.HazardousMaterialDescription, 1, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.HazardousMaterialClassification, 2, x => x.MinLength(1).MaxLength(30));
        }
    }
}