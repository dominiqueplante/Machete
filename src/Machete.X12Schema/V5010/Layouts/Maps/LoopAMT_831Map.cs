namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopAMT_831Map :
        X12LayoutMap<LoopAMT_831, X12Entity>
    {
        public LoopAMT_831Map()
        {
            Id = "Loop_AMT_831";
            Name = "Loop AMT";
            
            Segment(x => x.MonetaryAmountInformation, 0);
            Segment(x => x.QuantityInformation, 1);
        }
    }
}