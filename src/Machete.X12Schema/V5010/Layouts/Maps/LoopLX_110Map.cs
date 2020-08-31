namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLX_110Map :
        X12LayoutMap<LoopLX_110, X12Entity>
    {
        public LoopLX_110Map()
        {
            Id = "Loop_LX_110";
            Name = "Loop LX";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Layout(x => x.LoopN1, 1);
            Segment(x => x.Pickup, 2);
            Segment(x => x.RouteInformationAir, 3);
            Segment(x => x.ProofOfDelivery, 4);
            Segment(x => x.EventDetail, 5);
            Segment(x => x.RemittanceAdvice, 6);
            Segment(x => x.StatementIdentification, 7);
            Segment(x => x.NotesOrSpecialInstruction, 8);
            Layout(x => x.LoopL5, 9);
        }
    }
}