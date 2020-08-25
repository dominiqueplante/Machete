namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T754 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BGN> BeginningSegment { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        LayoutList<Loop0100_754> Loop0100 { get; }
        
        LayoutList<Loop0200_754> Loop0200 { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}