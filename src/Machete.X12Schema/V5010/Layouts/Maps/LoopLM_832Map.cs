namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLM_832Map :
        X12LayoutMap<LoopLM_832, X12Entity>
    {
        public LoopLM_832Map()
        {
            Id = "Loop_LM_832";
            Name = "Loop LM";
            
            Segment(x => x.CodeSourceInformation, 0);
            Layout(x => x.LoopLQ, 1);
        }
    }
}