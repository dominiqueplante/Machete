namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0150_212 :
        X12Layout
    {
        Segment<AT7> ShipmentStatusDetails { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        Segment<MS1> EquipmentShipmentOrRealPropertyLocation { get; }
        
        Layout<Loop0160_212> Loop0160 { get; }
    }
}