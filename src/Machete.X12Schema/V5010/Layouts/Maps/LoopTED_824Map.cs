namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopTED_824Map :
        X12LayoutMap<LoopTED_824, X12Entity>
    {
        public LoopTED_824Map()
        {
            Id = "Loop_TED_824";
            Name = "Loop TED";
            
            Segment(x => x.TechnicalErrorDescription, 0);
            Segment(x => x.Context, 1);
            Segment(x => x.NotesOrSpecialInstruction, 2);
            Segment(x => x.RelatedData, 3);
        }
    }
}