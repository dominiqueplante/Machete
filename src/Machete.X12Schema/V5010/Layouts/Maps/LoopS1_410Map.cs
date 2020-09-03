namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopS1_410Map :
        X12LayoutMap<LoopS1_410, X12Entity>
    {
        public LoopS1_410Map()
        {
            Id = "Loop_S1_410";
            Name = "Loop S1";
            
            Segment(x => x.StopOffName, 0);
            Segment(x => x.StopOffAddress, 1);
            Segment(x => x.StopOffStation, 2);
        }
    }
}