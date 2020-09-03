namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN1_410Map :
        X12LayoutMap<LoopN1_410, X12Entity>
    {
        public LoopN1_410Map()
        {
            Id = "Loop_N1_410";
            Name = "Loop N1";
            
            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.PartyLocation, 2);
            Segment(x => x.GeographicLocation, 3);
            Segment(x => x.AdministrativeCommunicationsContact, 4);
            Segment(x => x.BillingInformation, 5);
        }
    }
}