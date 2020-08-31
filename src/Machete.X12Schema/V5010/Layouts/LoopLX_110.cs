namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLX_110 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        LayoutList<LoopN1_110> LoopN1 { get; }
        
        SegmentList<P1> Pickup { get; }
        
        Segment<R1> RouteInformationAir { get; }
        
        SegmentList<POD> ProofOfDelivery { get; }
        
        Segment<V9> EventDetail { get; }
        
        Segment<RMT> RemittanceAdvice { get; }
        
        Segment<G47> StatementIdentification { get; }
        
        SegmentList<NTE> NotesOrSpecialInstruction { get; }
        
        LayoutList<LoopL5_110> LoopL5 { get; }
    }
}