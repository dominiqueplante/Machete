namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN1_3_832Map :
        X12LayoutMap<LoopN1_3_832, X12Entity>
    {
        public LoopN1_3_832Map()
        {
            Id = "Loop_N1_3_832";
            Name = "Loop N1";
            
            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.Text, 1);
            Segment(x => x.AdditionalNameInformation, 2);
            Segment(x => x.PartyLocation, 3);
            Segment(x => x.GeographicLocation, 4);
            Segment(x => x.ReferenceIdentification, 5);
            Segment(x => x.AdministrativeCommunicationsContact, 6);
            Segment(x => x.DateOrTimeReference, 7);
            Segment(x => x.Text, 8);
            Segment(x => x.MarkingPackagingOrLoading, 9);
            Segment(x => x.PalletTypeAndLoadCharacteristics, 10);
            Segment(x => x.SpecificationIdentifier, 11);
        }
    }
}