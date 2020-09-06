namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T311 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }
        
        Segment<B2A> SetPurpose { get; }
        
        SegmentList<Y6> Authentication { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        Segment<V1> VesselIdentification { get; }
        
        Segment<V2> VesselInformation { get; }
        
        Segment<V3> VesselSchedule { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
        
        LayoutList<LoopN1_311> LoopN1 { get; }
        
        SegmentList<R4> PortOrTerminal { get; }
        
        SegmentList<K1> Remarks1 { get; }
        
        LayoutList<LoopLX_311> LoopLX { get; }
        
        Segment<L3> TotalWeightAndCharges { get; }
        
        SegmentList<K1> Remarks2 { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}