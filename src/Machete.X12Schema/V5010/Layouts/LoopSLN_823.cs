namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSLN_823 :
        X12Layout
    {
        Segment<SLN> SublineItemDetail { get; }

        LayoutList<LoopREF_823> LoopREF { get; }

        LayoutList<LoopSAC_823> LoopSAC { get; }
    }
}