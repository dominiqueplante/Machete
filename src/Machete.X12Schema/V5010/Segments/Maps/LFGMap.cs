namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LFGMap :
        X12SegmentMap<LFG, X12Entity>
    {
        public LFGMap()
        {
            Id = "LFG";
            Name = "Hazardous Information, Finished Goods";
            
            Value(x => x.Description, 1, x => x.MinLength(2).MaxLength(80).IsRequired());
            Value(x => x.HazardousClassification, 2, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.UnitedNationsOrNorthAmericanIdentificationCode, 4, x=> x.FixedLength(6).IsRequired());
            Value(x => x.HazardousPlacardNotation, 3, x => x.MinLength(14).MaxLength(40).IsRequired());
            Value(x => x.PackingGroupCode, 4, x => x.MinLength(1).MaxLength(3));
            Value(x => x.HazardousMaterialRegulationsExceptionCode, 4, x=> x.FixedLength(1));
        }
    }
}