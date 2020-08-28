namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLQ_824Map :
        X12LayoutMap<LoopLQ_824, X12Entity>
    {
        public LoopLQ_824Map()
        {
            Id = "Loop_LQ_824";
            Name = "Loop LQ";
            
            Segment(x => x.IndustryCodeIdentification, 0);
            Segment(x => x.RelatedData, 1);
        }
    }
}