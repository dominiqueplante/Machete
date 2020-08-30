namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopITA_2_811Map :
        X12LayoutMap<LoopITA_2_811, X12Entity>
    {
        public LoopITA_2_811Map()
        {
            Id = "Loop_ITA_2_811";
            Name = "Loop ITA";
            
            Segment(x => x.AllowanceChargeOrService, 0);
            Segment(x => x.DateOrTimeReference, 1);
            Segment(x => x.ReferenceInformation, 2);
        }
    }
}