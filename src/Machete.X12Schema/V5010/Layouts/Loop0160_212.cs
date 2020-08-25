namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0160_212 :
        X12Layout
    {
        SegmentList<MS2> EquipmentOrContainerOwnerAndType { get; }
        
        SegmentList<M7> SealNumbers { get; }
        
        Segment<AT9> TrailerOrContainerDimensionAndWeight { get; }
    }
}