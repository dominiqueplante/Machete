namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPEN_823Map :
        X12LayoutMap<LoopPEN_823, X12Entity>
    {
        public LoopPEN_823Map()
        {
            Id = "Loop_PEN_823";
            Name = "Loop PEN";
            
            Segment(x => x.PensionInformation, 0);
            Segment(x => x.MonetaryAmountInformation, 1);
            Segment(x => x.DateOrTimeOrPeriod, 2);
            Layout(x => x.LoopINV, 3);
        }
    }
}