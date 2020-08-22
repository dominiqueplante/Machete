namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0300_210Map :
        X12LayoutMap<Loop0300_210, X12Entity>
    {
        public Loop0300_210Map()
        {
            Id = "Loop_0300_210";
            Name = "Loop 0300";
            
            Segment(x => x.StopOffDetails, 0);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 1);
            Segment(x => x.DateOrTime, 2);
            Segment(x => x.SpecialHandlingInstructions, 3);
            Layout(x => x.Loop0305, 4);
            Layout(x => x.Loop0310, 5);
        }
    }
}