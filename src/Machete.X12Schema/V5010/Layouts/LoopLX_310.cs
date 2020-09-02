namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLX_310 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        LayoutList<LoopN7_310> LoopN7 { get; }
        
        LayoutList<LoopL0_310> LoopL0 { get; }
    }
}