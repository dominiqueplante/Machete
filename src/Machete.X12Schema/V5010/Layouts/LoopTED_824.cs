namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopTED_824 :
        X12Layout
    {
        SegmentList<TED> TechnicalErrorDescription { get; }
        
        SegmentList<CTX> Context { get; }
        
        SegmentList<NTE> NotesOrSpecialInstruction { get; }
        
        SegmentList<RED> RelatedData { get; }
    }
}