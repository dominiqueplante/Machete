namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopIT1_823 :
        X12Layout
    {
        Segment<IT1> BaselineItemData { get; }

        LayoutList<LoopREF_823> LoopREF { get; }
        
        LayoutList<LoopSAC_823> LoopSAC { get; }
        
        LayoutList<LoopSLN_823> LoopSLN { get; }
    }
}