namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLX_311Map :
        X12LayoutMap<LoopLX_311, X12Entity>
    {
        public LoopLX_311Map()
        {
            Id = "Loop_LX_311";
            Name = "Loop LX";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.ContainerDetails, 1);
            Layout(x => x.LoopED, 2);
            Layout(x => x.LoopL0, 3);
        }
    }
}