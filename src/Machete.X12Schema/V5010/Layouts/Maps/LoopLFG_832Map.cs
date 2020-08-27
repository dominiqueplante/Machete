namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLFG_832Map :
        X12LayoutMap<LoopLFG_832, X12Entity>
    {
        public LoopLFG_832Map()
        {
            Id = "Loop_LFG_832";
            Name = "Loop LFG";
            
            Segment(x => x.HazardousInformationFinishedGoods, 0);
            Layout(x => x.LoopCRC, 1);
        }
    }
}