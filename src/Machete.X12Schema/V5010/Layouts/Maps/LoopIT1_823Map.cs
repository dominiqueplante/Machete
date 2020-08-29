namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopIT1_823Map :
        X12LayoutMap<LoopIT1_823, X12Entity>
    {
        public LoopIT1_823Map()
        {
            Id = "Loop_IT1_823";
            Name = "Loop IT1";
            
            Segment(x => x.BaselineItemData, 0);
            Layout(x => x.LoopREF, 1);
            Layout(x => x.LoopSAC, 2);
            Layout(x => x.LoopSLN, 3);
        }
    }
}