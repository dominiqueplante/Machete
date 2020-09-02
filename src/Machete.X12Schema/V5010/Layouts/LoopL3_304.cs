namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopL3_304 :
        X12Layout
    {
        Segment<L3> TotalWeightAndCharges { get; }
        
        Segment<CUR> Currency { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        SegmentList<PWK> Paperwork { get; }
        
        SegmentList<SUP> SupplementaryInformation { get; }
        
        LayoutList<LoopL1_304> LoopL1 { get; }
        
        LayoutList<LoopTDS_304> LoopTDS { get; }
        
        LayoutList<LoopSAC_304> LoopSAC { get; }
        
        LayoutList<LoopL9_304> LoopL9 { get; }
        
        SegmentList<ISS> InvoiceShipmentSummary { get; }
        
        SegmentList<V9> EventDetail { get; }
        
        SegmentList<K1> Remarks { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }
    }
}