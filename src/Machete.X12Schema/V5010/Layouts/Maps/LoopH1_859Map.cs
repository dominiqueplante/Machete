namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopH1_859Map :
        X12LayoutMap<LoopH1_859, X12Entity>
    {
        public LoopH1_859Map()
        {
            Id = "Loop_H1_859";
            Name = "Loop H1";
            
            Segment(x => x.HazardousMaterial, 0);
            Segment(x => x.AdditionalHazardousMaterialDescription, 1);
        }
    }
}