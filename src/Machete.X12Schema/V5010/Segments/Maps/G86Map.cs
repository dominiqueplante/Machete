namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G86Map :
        X12SegmentMap<G86, X12Entity>
    {
        public G86Map()
        {
            Id = "G86";
            Name = "Signature Identification";
            
            Value(x => x.Signature, 1, x => x.MinLength(1).MaxLength(12));
            Value(x => x.Name, 2, x => x.MinLength(1).MaxLength(60));
        }
    }
}