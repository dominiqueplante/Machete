namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0460_210Map :
        X12LayoutMap<Loop0460_210, X12Entity>
    {
        public Loop0460_210Map()
        {
            Id = "Loop_0460_210";
            Name = "Loop 0460";
            
            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.PartyLocation, 2);
            Segment(x => x.GeographicLocation, 3);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 4);
            Layout(x => x.Loop0463, 5);
            Layout(x => x.Loop0465, 6);
        }
    }
}