namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN7_410 :
        X12Layout
    {
        Segment<N7> EquipmentDetails { get; }
        
        SegmentList<VC> MotorVehicleControl { get; }
        
        SegmentList<G4> ScaleIdentification { get; }
        
        SegmentList<M7> SealNumbers { get; }
        
        Segment<N5> EquipmentOrdered { get; }
        
        Segment<IC> IntermodalChassisEquipment { get; }
        
        Segment<IM> IntermodalMovementInformation { get; }
        
        SegmentList<M12> InbondIdentifyingInformation { get; }
        
        SegmentList<GA> CanadianGrainInformation { get; }
    }
}