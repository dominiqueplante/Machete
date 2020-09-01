namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopY2_300Map :
        X12LayoutMap<LoopY2_300, X12Entity>
    {
        public LoopY2_300Map()
        {
            Id = "Loop_Y2_300";
            Name = "Loop Y2";
            
            Segment(x => x.ContainerDetails, 0);
            Segment(x => x.EquipmentAndTemperature, 1);
        }
    }
}