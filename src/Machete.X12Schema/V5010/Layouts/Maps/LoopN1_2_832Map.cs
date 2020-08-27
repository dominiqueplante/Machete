namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN1_2_832Map :
        X12LayoutMap<LoopN1_2_832, X12Entity>
    {
        public LoopN1_2_832Map()
        {
            Id = "Loop_N1_2_832";
            Name = "Loop N1";
            
            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.PartyLocation, 2);
            Segment(x => x.GeographicLocation, 3);
        }
    }
}