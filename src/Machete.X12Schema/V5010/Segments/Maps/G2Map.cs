namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G2Map :
        X12SegmentMap<G2, X12Entity>
    {
        public G2Map()
        {
            Id = "G2";
            Name = "Beyond Routing";
            
            Value(x => x.SpecialIndicatorCode, 1, x => x.FixedLength(1).IsRequired());
            Value(x => x.Description, 2, x => x.MinLength(1).MaxLength(80));
        }
    }
}