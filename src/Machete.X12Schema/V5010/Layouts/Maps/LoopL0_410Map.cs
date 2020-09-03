namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopL0_410Map :
        X12LayoutMap<LoopL0_410, X12Entity>
    {
        public LoopL0_410Map()
        {
            Id = "Loop_L0_410";
            Name = "Loop L0";
            
            Segment(x => x.LineItemQuantityAndWeight, 0);
            Segment(x => x.Measurements, 1);
            Segment(x => x.RateAndCharges, 2);
            Segment(x => x.DateOrTimeReference, 3);
            Segment(x => x.Pickup, 4);
        }
    }
}