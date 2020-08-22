namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class K1Map :
        X12SegmentMap<K1, X12Entity>
    {
        public K1Map()
        {
            Id = "K1";
            Name = "Remarks";
            
            Value(x => x.FreeformInformation1, 1, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.FreeformInformation2, 2, x => x.MinLength(1).MaxLength(30));
        }
    }
}