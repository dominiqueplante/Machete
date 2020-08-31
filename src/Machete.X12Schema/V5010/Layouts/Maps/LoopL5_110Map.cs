namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopL5_110Map :
        X12LayoutMap<LoopL5_110, X12Entity>
    {
        public LoopL5_110Map()
        {
            Id = "Loop_L5_110";
            Name = "Loop L5";
            
            Segment(x => x.DescriptionMarksAndNumbers, 0);
            Segment(x => x.LineItemQuantityAndWeight, 1);
            Segment(x => x.Measurement, 2);
            Segment(x => x.WeightInformation, 3);
            Segment(x => x.TariffDetails, 4);
            Layout(x => x.LoopL1, 5);
        }
    }
}