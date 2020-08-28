namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T824 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }

        SegmentList<BGN> BeginningSegment { get; }

        LayoutList<LoopN1_824> LoopN1 { get; }

        LayoutList<LoopOTI_824> LoopOTI { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}