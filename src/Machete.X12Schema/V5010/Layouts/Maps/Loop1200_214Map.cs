namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop1200_214Map :
        X12LayoutMap<Loop1200_214, X12Entity>
    {
        public Loop1200_214Map()
        {
            Id = "Loop_1200_214";
            Name = "Loop 1200";
            
            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.PartyLocation, 2);
            Segment(x => x.GeographicLocation, 3);
            Segment(x => x.DateOrTime, 4);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 5);
        }
    }
}