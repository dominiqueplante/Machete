namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLFG_832 :
        X12Layout
    {
        Segment<LFG> HazardousInformationFinishedGoods { get; }
        
        LayoutList<LoopCRC_832> LoopCRC { get; }
    }
}