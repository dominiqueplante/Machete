namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLX_410Map :
        X12LayoutMap<LoopLX_410, X12Entity>
    {
        public LoopLX_410Map()
        {
            Id = "Loop_LX_410";
            Name = "Loop LX";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.DescriptionMarksAndNumbers, 1);
            Layout(x => x.LoopL0, 2);
        }
    }
}