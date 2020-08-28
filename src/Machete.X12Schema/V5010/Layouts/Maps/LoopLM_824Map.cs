namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLM_824Map :
        X12LayoutMap<LoopLM_824, X12Entity>
    {
        public LoopLM_824Map()
        {
            Id = "Loop_LM_824";
            Name = "Loop LM";
            
            Segment(x => x.CodeSourceInformation, 0);
            Layout(x => x.LoopLQ, 1);
        }
    }
}