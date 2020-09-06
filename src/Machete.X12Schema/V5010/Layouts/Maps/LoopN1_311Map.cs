namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN1_311Map :
        X12LayoutMap<LoopN1_311, X12Entity>
    {
        public LoopN1_311Map()
        {
            Id = "Loop_N1_311";
            Name = "Loop N1";
            
            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.PartyLocation, 2);
            Segment(x => x.GeographicLocation, 3);
        }
    }
}