namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopL0_417Map :
        X12LayoutMap<LoopL0_417, X12Entity>
    {
        public LoopL0_417Map()
        {
            Id = "Loop_L0_417";
            Name = "Loop L0";
            
            Segment(x => x.LineItemQuantityAndWeight, 0);
            Segment(x => x.Measurements, 1);
            Segment(x => x.Pickup, 2);
        }
    }
}