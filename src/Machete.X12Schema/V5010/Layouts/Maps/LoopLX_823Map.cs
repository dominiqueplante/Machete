namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLX_823Map :
        X12LayoutMap<LoopLX_823, X12Entity>
    {
        public LoopLX_823Map()
        {
            Id = "Loop_LX_823";
            Name = "Loop LX";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.ReferenceInformation, 1);
            Segment(x => x.Trace, 2);
            Layout(x => x.LoopNM1, 3);
        }
    }
}