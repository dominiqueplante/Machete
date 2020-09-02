namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopL0_310Map :
        X12LayoutMap<LoopL0_310, X12Entity>
    {
        public LoopL0_310Map()
        {
            Id = "Loop_L0_310";
            Name = "Loop L0";
            
            Segment(x => x.LineItemQuantityAndWeight, 0);
            Segment(x => x.DescriptionMarksAndNumbers, 1);
            Layout(x => x.LoopL1, 2);
            Segment(x => x.TariffReference, 3);
            Segment(x => x.ExportLicense, 4);
            Segment(x => x.ImportLicense, 5);
            Layout(x => x.LoopC8, 6);
            Layout(x => x.LoopH1, 7);
            Layout(x => x.LoopLH1, 8);
        }
    }
}