namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class H1Map :
        X12SegmentMap<H1, X12Entity>
    {
        public H1Map()
        {
            Id = "H1";
            Name = "Hazardous Material";
            
            Value(x => x.HazardousMaterialCode, 1, x => x.MinLength(4).MaxLength(10));
            Value(x => x.HazardousMaterialClassCode, 2, x => x.MinLength(1).MaxLength(4));
            Value(x => x.HazardousMaterialCodeQualifier, 3, x => x.FixedLength(1));
            Value(x => x.HazardousMaterialDescription, 4, x => x.MinLength(1).MaxLength(30));
            Value(x => x.HazardousMaterialContact, 5, x => x.MinLength(1).MaxLength(24));
            Value(x => x.HazardousMaterialsPage, 6, x => x.MinLength(1).MaxLength(6));
            Value(x => x.FlashpointTemperature, 7, x => x.MinLength(1).MaxLength(3));
            Value(x => x.UnitOrBasisOfMeasurementCode, 8, x => x.FixedLength(2));
            Value(x => x.PackingGroupCode, 9, x => x.MinLength(1).MaxLength(3));
        }
    }
}