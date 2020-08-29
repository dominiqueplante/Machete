namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopADX_823 :
        X12Layout
    {
        Segment<ADX> Adjustments { get; }
        
        SegmentList<NTE> NotesOrSpecialInstruction { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        Segment<DTM> DateOrTimeReference { get; }

        LayoutList<LoopREF_823> LoopREF { get; }
        
        LayoutList<LoopIT1_823> LoopIT1 { get; }
    }
}