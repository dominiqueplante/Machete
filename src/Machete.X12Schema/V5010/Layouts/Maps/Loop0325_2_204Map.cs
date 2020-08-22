namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0325_2_204Map :
        X12LayoutMap<Loop0325_2_204, X12Entity>
    {
        public Loop0325_2_204Map()
        {
            Id = "Loop_0325_2_204";
            Name = "Loop 0325";
            
            Segment(x => x.Contact, 0);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 1);
            Segment(x => x.HazardousCertification, 2);
            Layout(x => x.Loop0330, 3);
        }
    }
}