namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G85Map :
        X12SegmentMap<G85, X12Entity>
    {
        public G85Map()
        {
            Id = "G85";
            Name = "Record Integrity Check";
            
            Value(x => x.IntegrityCheckValue, 1, x => x.MinLength(1).MaxLength(12).IsRequired());
        }
    }
}