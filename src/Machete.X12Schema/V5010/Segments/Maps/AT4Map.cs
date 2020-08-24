namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class AT4Map :
        X12SegmentMap<AT4, X12Entity>
    {
        public AT4Map()
        {
            Id = "AT4";
            Name = "Bill of Lading Description";
            
            Value(x => x.LadingDescription, 1, x => x.MinLength(2).MaxLength(50).IsRequired());
        }
    }
}