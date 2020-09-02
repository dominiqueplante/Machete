namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLX_310Map :
        X12LayoutMap<LoopLX_310, X12Entity>
    {
        public LoopLX_310Map()
        {
            Id = "Loop_LX_310";
            Name = "Loop LX";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Layout(x => x.LoopN7, 1);
            Layout(x => x.LoopL0, 2);
        }
    }
}