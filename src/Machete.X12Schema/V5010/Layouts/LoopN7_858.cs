namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN7_858 : 
        X12Layout
    {
        Segment<N7> EquipmentDetails { get; }
        
        Segment<EM> EquipmentCharacteristics { get; }
        
        SegmentList<NA> CrossReferenceEquipment { get; }
        
        SegmentList<M7> SealNumbers { get; }
        
        Segment<N5> EquipmentOrdered { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        Segment<IC> IntermodalChassisEquipment { get; }
        
        SegmentList<VC> MotorVehicleControl { get; }
        
        SegmentList<GA> CanadianGrainInformation { get; }
        
        LayoutList<LoopE1_858> LoopE1 { get;  }
    }
}