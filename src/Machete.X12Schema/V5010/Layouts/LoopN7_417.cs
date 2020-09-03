namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN7_417 :
        X12Layout
    {
        Segment<N7> EquipmentDetails { get; }
        
        Segment<EM> EquipmentCharacteristics { get; }
        
        LayoutList<LoopVC_417> LoopVC { get; }
        
        Segment<IC> IntermodalChassisEquipment { get; }
        
        Segment<IM> IntermodalMovementInformation { get; }
        
        SegmentList<M12> InbondIdentifyingInformation { get; }
        
        SegmentList<G4> ScaleIdentification { get; }
        
        SegmentList<M7> SealNumbers { get; }
        
        Segment<N5> EquipmentOrdered { get; }
        
        Segment<H5> CarServiceOrder { get; }
        
        LayoutList<LoopE1_417> LoopE1 { get; }
        
        SegmentList<GA> CanadianGrainInformation { get; }
        
        LayoutList<LoopREF_417> LoopREF { get; }
        
        SegmentList<IMA> InterchangeMoveAuthority { get; }
    }
}