namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopBAT_823Map :
        X12LayoutMap<LoopBAT_823, X12Entity>
    {
        public LoopBAT_823Map()
        {
            Id = "Loop_BAT_823";
            Name = "Loop BAT";
            
            Segment(x => x.Batch, 0);
            Segment(x => x.FundsAvailability, 1);
            Segment(x => x.MonetaryAmountInformation, 2);
            Segment(x => x.QuantityInformation, 3);
            Segment(x => x.DateOrTimeReference, 4);
            Layout(x => x.LoopBPR, 5);
        }
    }
}