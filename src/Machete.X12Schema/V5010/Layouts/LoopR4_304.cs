namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopR4_304 :
        X12Layout
    {
        Segment<R4> PortOrTerminal { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
    }
}