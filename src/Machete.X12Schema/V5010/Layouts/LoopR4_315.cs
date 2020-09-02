namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopR4_315 :
        X12Layout
    {
        Segment<R4> PortOrTerminal { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
    }
}