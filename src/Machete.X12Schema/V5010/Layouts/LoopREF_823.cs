namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopREF_823 :
        X12Layout
    {
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
    }
}