namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN1_2_417Map :
        X12LayoutMap<LoopN1_2_417, X12Entity>
    {
        public LoopN1_2_417Map()
        {
            Id = "Loop_N1_2_417";
            Name = "Loop N1";
            
            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.PartyLocation, 1);
            Segment(x => x.GeographicLocation, 2);
        }
    }
}