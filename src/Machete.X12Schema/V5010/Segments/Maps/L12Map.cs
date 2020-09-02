namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L12Map :
        X12SegmentMap<L12, X12Entity>
    {
        public L12Map()
        {
            Id = "L12";
            Name = "Alternate Lading Description";
            
            Value(x => x.LadingDescriptionQualifier, 1, x => x.FixedLength(1));
            Value(x => x.Description, 2, x => x.MinLength(1).MaxLength(80));
        }
    }
}