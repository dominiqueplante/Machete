namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopH1_310Map :
        X12LayoutMap<LoopH1_310, X12Entity>
    {
        public LoopH1_310Map()
        {
            Id = "Loop_H1_310";
            Name = "Loop H1";
            
            Segment(x => x.HazardousMaterial, 0);
            Segment(x => x.AdditionalHazardousMaterialDescription, 1);
        }
    }
}