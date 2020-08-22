namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0365_204Map :
        X12LayoutMap<Loop0365_204, X12Entity>
    {
        public Loop0365_204Map()
        {
            Id = "Loop_0365_204";
            Name = "Loop 0365";
            
            Segment(x => x.Contact, 0);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 1);
            Segment(x => x.HazardousCertification, 2);
            Layout(x => x.Loop0370, 3);
        }
    }
}