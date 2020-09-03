namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopS1_417Map :
        X12LayoutMap<LoopS1_417, X12Entity>
    {
        public LoopS1_417Map()
        {
            Id = "Loop_S1_417";
            Name = "Loop S1";
            
            Segment(x => x.StopOffName, 0);
            Segment(x => x.StopOffAddress, 1);
            Segment(x => x.StopOffStation, 2);
            Segment(x => x.PartyIdentification, 3);
            Segment(x => x.AdditionalNameInformation, 4);
            Segment(x => x.PartyLocation, 5);
            Segment(x => x.GeographicLocation, 6);
            Segment(x => x.AdministrativeCommunicationsContact, 7);
        }
    }
}