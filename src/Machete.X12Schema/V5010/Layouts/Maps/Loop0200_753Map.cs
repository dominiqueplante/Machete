namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0200_753Map :
        X12LayoutMap<Loop0200_753, X12Entity>
    {
        public Loop0200_753Map()
        {
            Id = "Loop_0200_753";
            Name = "Loop 0200";

            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.PartyLocation, 2);
            Segment(x => x.GeographicLocation, 3);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 4);
            Segment(x => x.DateOrTime, 5);
            Segment(x => x.Contact, 6);
            Layout(x => x.Loop0210, 7);
        }
    }
}