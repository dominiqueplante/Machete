namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0310_210Map :
        X12LayoutMap<Loop0310_210, X12Entity>
    {
        public Loop0310_210Map()
        {
            Id = "Loop_0310_210";
            Name = "Loop 0310";
            
            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.PartyLocation, 2);
            Segment(x => x.GeographicLocation, 3);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 4);
        }
    }
}