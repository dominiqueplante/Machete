namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T823 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }

        LayoutList<LoopN1_823> LoopN1 { get; }

        Segment<TRN> Trace { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }

        LayoutList<LoopDEP_823> LoopDEP { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}