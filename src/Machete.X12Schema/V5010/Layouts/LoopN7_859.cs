namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN7_859 :
        X12Layout
    {
        Segment<N7> EquipmentDetails { get; }
        
        SegmentList<M7> SealNumbers { get; }
        
        Segment<N5> EquipmentOrdered { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        Segment<IC> IntermodalChassisEquipment { get; }
        
        SegmentList<VC> MotorVehicleControl { get; }
        
        SegmentList<G4> ScaleIdentification { get; }
        
        SegmentList<GA> CanadianGrainInformation { get; }
    }
}