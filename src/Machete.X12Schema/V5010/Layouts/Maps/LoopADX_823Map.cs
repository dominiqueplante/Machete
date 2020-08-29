namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopADX_823Map :
        X12LayoutMap<LoopADX_823, X12Entity>
    {
        public LoopADX_823Map()
        {
            Id = "Loop_ADX_823";
            Name = "Loop ADX";
            
            Segment(x => x.Adjustments, 0);
            Segment(x => x.NotesOrSpecialInstruction, 1);
            Segment(x => x.AdministrativeCommunicationsContact, 2);
            Segment(x => x.DateOrTimeReference, 3);
            Layout(x => x.LoopREF, 4);
            Layout(x => x.LoopIT1, 5);
        }
    }
}