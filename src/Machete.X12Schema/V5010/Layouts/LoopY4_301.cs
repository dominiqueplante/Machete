namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopY4_301 :
        X12Layout
    {
        Segment<Y4> ContainerRelease { get; }
        
        Segment<W09> EquipmentAndTemperature { get; }
    }
}