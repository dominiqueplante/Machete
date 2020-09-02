namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T315 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }

        Segment<B4> BeginningSegmentForInquiryOrReply { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        Segment<Q2> StatusDetails { get; }
        
        SegmentList<SG> ShipmentDetails { get; }
        
        LayoutList<LoopR4_315> LoopR4 { get; }
        
        SegmentList<V9> EventDetail { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}