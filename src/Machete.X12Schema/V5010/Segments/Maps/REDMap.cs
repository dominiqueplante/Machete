namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class REDMap :
        X12SegmentMap<RED, X12Entity>
    {
        public REDMap()
        {
            Id = "RED";
            Name = "Related Data";
            
            Value(x => x.Description, 1, x => x.MinLength(1).MaxLength(80).IsRequired());
            Value(x => x.RelatedDataIdentificationCode, 2, x => x.MinLength(2).MaxLength(3));
            Value(x => x.AgencyQualifierCode, 3, x => x.FixedLength(2));
            Value(x => x.SourceSubqualifier, 4, x => x.MinLength(1).MaxLength(15));
            Value(x => x.CodeListQualifierCode, 5, x => x.MinLength(1).MaxLength(3));
            Value(x => x.IndustryCode, 6, x => x.MinLength(1).MaxLength(30));
        }
    }
}