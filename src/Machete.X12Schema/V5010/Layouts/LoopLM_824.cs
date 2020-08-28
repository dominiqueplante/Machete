namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLM_824 :
        X12Layout
    {
        Segment<LM> CodeSourceInformation { get; }

        LayoutList<LoopLQ_824> LoopLQ { get; }
    }
}