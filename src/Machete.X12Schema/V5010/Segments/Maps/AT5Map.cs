namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class AT5Map :
        X12SegmentMap<AT5, X12Entity>
    {
        public AT5Map()
        {
            Id = "AT5";
            Name = "Bill of Lading Handling Requirements";
            
            Value(x => x.SpecialHandlingCode, 1, x => x.MinLength(2).MaxLength(3));
            Value(x => x.SpecialServicesCode, 2, x => x.MinLength(2).MaxLength(10));
            Value(x => x.SpecialHandlingDescription, 3, x => x.MinLength(2).MaxLength(30));
            Value(x => x.UnitOrBasisOfMeasurementCode, 4, x => x.FixedLength(2));
            Value(x => x.Temperature1, 5, x => x.MinLength(1).MaxLength(4));
            Value(x => x.Temperature2, 6, x => x.MinLength(1).MaxLength(4));
        }
    }
}