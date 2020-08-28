namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLM_830Map :
        X12LayoutMap<LoopLM_830, X12Entity>
    {
        public LoopLM_830Map()
        {
            Id = "Loop_LM_830";
            Name = "Loop LM";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCodeIdentification, 1);
        }
    }
}