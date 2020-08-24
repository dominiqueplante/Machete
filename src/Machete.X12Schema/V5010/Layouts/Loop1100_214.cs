namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop1100_214 :
        X12Layout
    {
        Segment<AT7> ShipmentStatusDetails { get; }
        
        Segment<MS1> EquipmentShipmentOrRealPropertyLocation { get; }
        
        SegmentList<MS2> EquipmentOrContainerOwnerAndType { get; }
        
        SegmentList<K1> Remarks { get; }
        
        SegmentList<M7> SealNumbers { get; }
    }
}