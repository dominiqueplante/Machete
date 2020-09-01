namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopY2_300 :
        X12Layout
    {
        Segment<Y2> ContainerDetails { get; }
        
        Segment<W09> EquipmentAndTemperature { get; }
    }
}