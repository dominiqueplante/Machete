namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLX_2_811Map :
        X12LayoutMap<LoopLX_2_811, X12Entity>
    {
        public LoopLX_2_811Map()
        {
            Id = "Loop_LX_2_811";
            Name = "Loop LX";

            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.ReferenceInformation, 1);
            Layout(x => x.LoopAMT, 2);
            Layout(x => x.LoopITA, 3);
        }
    }
}