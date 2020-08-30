namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopITA_4_811Map :
        X12LayoutMap<LoopITA_4_811, X12Entity>
    {
        public LoopITA_4_811Map()
        {
            Id = "Loop_ITA_4_811";
            Name = "Loop ITA";
            
            Segment(x => x.AllowanceChargeOrService, 0);
            Segment(x => x.DateOrTimeReference, 1);
        }
    }
}