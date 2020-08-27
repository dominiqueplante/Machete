namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLM_832 :
        X12Layout
    {
        Segment<LM> CodeSourceInformation { get; }
        
        LayoutList<LoopLQ_832> LoopLQ { get; }
    }
}