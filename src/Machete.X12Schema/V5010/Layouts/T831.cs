namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T831 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }

        Segment<BGN> BeginningSegment { get; }

        SegmentList<DTM> DateOrTimeReference { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<TRN> Trace { get; }
        
        SegmentList<QTY> QuantityInformation { get; }
        
        LayoutList<LoopAMT_831> LoopAMT { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}