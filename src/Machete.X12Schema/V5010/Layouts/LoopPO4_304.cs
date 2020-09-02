namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopPO4_304 :
        X12Layout
    {
        Segment<PO4> ItemPhysicalDetails { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
    }
}