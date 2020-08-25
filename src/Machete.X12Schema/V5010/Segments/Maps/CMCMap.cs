namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class CMCMap :
        X12SegmentMap<CMC, X12Entity>
    {
        public CMCMap()
        {
            Id = "CMC";
            Name = "Commodity Classification";
            
            Value(x => x.CommodityCode, 1, x => x.MinLength(1).MaxLength(30));
            Value(x => x.FreightClassCode, 2, x => x.MinLength(2).MaxLength(5));
        }
    }
}