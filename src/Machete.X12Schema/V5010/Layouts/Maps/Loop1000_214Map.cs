namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop1000_214Map :
        X12LayoutMap<Loop1000_214, X12Entity>
    {
        public Loop1000_214Map()
        {
            Id = "Loop_1000_214";
            Name = "Loop 1000";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 1);
            Segment(x => x.MarksAndNumbersInformation, 2);
            Segment(x => x.LadingExceptionStatus, 2);
            Segment(x => x.Remarks, 3);
            Segment(x => x.BillOfLadingHandlingRequirements, 4);
            Segment(x => x.ShipmentWeightPackagingAndQuantityData, 5);
            Layout(x => x.Loop1100, 6);
            Layout(x => x.Loop1200, 7);
            Layout(x => x.Loop1300, 8);
        }
    }
}