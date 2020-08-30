namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopL0_859Map :
        X12LayoutMap<LoopL0_859, X12Entity>
    {
        public LoopL0_859Map()
        {
            Id = "Loop_L0_859";
            Name = "Loop L0";
            
            Segment(x => x.LineItemQuantityAndWeight, 0);
            Segment(x => x.RateAndCharges, 1);
            Segment(x => x.Measurements, 2);
        }
    }
}