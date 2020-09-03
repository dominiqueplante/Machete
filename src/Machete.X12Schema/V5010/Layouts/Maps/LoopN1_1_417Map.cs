namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN1_1_417Map :
        X12LayoutMap<LoopN1_1_417, X12Entity>
    {
        public LoopN1_1_417Map()
        {
            Id = "Loop_N1_1_417";
            Name = "Loop N1";
            
            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.PartyLocation, 1);
            Segment(x => x.GeographicLocation, 2);
            Segment(x => x.SpecialHandlingInstructions, 3);
        }
    }
}