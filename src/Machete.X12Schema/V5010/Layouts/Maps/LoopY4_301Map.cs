namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopY4_301Map :
        X12LayoutMap<LoopY4_301, X12Entity>
    {
        public LoopY4_301Map()
        {
            Id = "Loop_Y4_301";
            Name = "Loop Y4";
            
            Segment(x => x.ContainerRelease, 0);
            Segment(x => x.EquipmentAndTemperature, 1);
        }
    }
}