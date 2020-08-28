namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopOTI_824Map :
        X12LayoutMap<LoopOTI_824, X12Entity>
    {
        public LoopOTI_824Map()
        {
            Id = "Loop_OTI_824";
            Name = "Loop OTI";
            
            Segment(x => x.OriginalTransactionIdentification, 0);
            Segment(x => x.ReferenceInformation, 1);
            Segment(x => x.DateOrTimeReference, 2);
            Segment(x => x.AdministrativeCommunicationsContact, 3);
            Segment(x => x.MonetaryAmountInformation, 4);
            Segment(x => x.QuantityInformation, 5);
            Segment(x => x.IndividualOrOrganizationalName, 6);
            Layout(x => x.LoopTED, 7);
            Layout(x => x.LoopLM, 8);
        }
    }
}