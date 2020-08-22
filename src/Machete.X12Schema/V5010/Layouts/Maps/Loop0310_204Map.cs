namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0310_204Map :
        X12LayoutMap<Loop0310_204, X12Entity>
    {
        public Loop0310_204Map()
        {
            Id = "Loop_0310_204";
            Name = "Loop 0310";
            
            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.PartyLocation, 2);
            Segment(x => x.GeographicLocation, 3);
            Segment(x => x.Contact, 4);
        }
    }
}