namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0100_204Map :
        X12LayoutMap<Loop0100_204, X12Entity>
    {
        public Loop0100_204Map()
        {
            Id = "Loop_0100_204";
            Name = "Loop 0100";
            
            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.PartyLocation, 2);
            Segment(x => x.GeographicLocation, 3);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 4);
            Segment(x => x.Contact, 5);
        }
    }
}