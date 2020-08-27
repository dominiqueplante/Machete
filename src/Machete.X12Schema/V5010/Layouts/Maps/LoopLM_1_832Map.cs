namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLM_1_832Map :
        X12LayoutMap<LoopLM_1_832, X12Entity>
    {
        public LoopLM_1_832Map()
        {
            Id = "LoopLM_1_832";
            Name = "Loop LM";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCodeIdentification, 1);
        }
    }
}