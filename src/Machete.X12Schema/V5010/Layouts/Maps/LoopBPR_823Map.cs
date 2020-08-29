namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopBPR_823Map :
        X12LayoutMap<LoopBPR_823, X12Entity>
    {
        public LoopBPR_823Map()
        {
            Id = "Loop_BPR_823";
            Name = "Loop BPR";
            
            Segment(x => x.BeginningSegmentForPaymentOrderOrRemittanceAdvice, 0);
            Segment(x => x.Trace, 1);
            Segment(x => x.Currency, 2);
            Segment(x => x.ReferenceInformation, 3);
            Segment(x => x.DateOrTimeReference, 4);
            Segment(x => x.FundsAvailability, 5);
            Layout(x => x.LoopADX, 6);
            Layout(x => x.LoopN1, 7);
            Layout(x => x.LoopRMR, 8);
            Layout(x => x.LoopTXP, 9);
            Layout(x => x.LoopDED, 10);
            Layout(x => x.LoopLX, 11);
        }
    }
}