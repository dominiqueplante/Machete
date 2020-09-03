namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopT1_417Map :
        X12LayoutMap<LoopT1_417, X12Entity>
    {
        public LoopT1_417Map()
        {
            Id = "Loop_T1_417";
            Name = "Loop T1";
            
            Segment(x => x.TransitInboundOrigin, 0);
            Segment(x => x.TransitInboundLading, 1);
            Segment(x => x.TransitInboundRoute, 2);
            Segment(x => x.TransitInboundRates, 3);
            Segment(x => x.FreeformTransitData, 4);
        }
    }
}