namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLX_304Map :
        X12LayoutMap<LoopLX_304, X12Entity>
    {
        public LoopLX_304Map()
        {
            Id = "Loop_LX_304";
            Name = "Loop LX";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.ContainerDetails, 1);
            Layout(x => x.LoopN7, 2);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 3);
            Segment(x => x.Remarks, 4);
            Layout(x => x.LoopPO4, 5);
            Layout(x => x.LoopL0, 6);
        }
    }
}