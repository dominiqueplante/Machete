namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0220_212Map :
        X12LayoutMap<Loop0220_212, X12Entity>
    {
        public Loop0220_212Map()
        {
            Id = "Loop_0220_212";
            Name = "Loop 0220";
            
            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.PartyLocation, 2);
            Segment(x => x.GeographicLocation, 3);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 4);
        }
    }
}