namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class K2Map :
        X12SegmentMap<K2, X12Entity>
    {
        public K2Map()
        {
            Id = "K2";
            Name = "Administrative Message";
            
            Value(x => x.Description, 1, x => x.MinLength(2).MaxLength(80).IsRequired());
        }
    }
}