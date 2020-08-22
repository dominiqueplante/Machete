namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0300_204Map :
        X12LayoutMap<Loop0300_204, X12Entity>
    {
        public Loop0300_204Map()
        {
            Id = "Loop_0300_204";
            Name = "Loop 0300";
            
            Segment(x => x.StopOffDetails, 0);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 1);
            Segment(x => x.ShipmentWeightPackagingAndQuantityData, 2);
            Segment(x => x.LadingDetail, 3);
            Layout(x => x.Loop0305, 4);
            Segment(x => x.PalletShipmentInformation, 5);
            Segment(x => x.NotesOrSpecialInstruction, 6);
            Layout(x => x.Loop0310, 7);
            Layout(x => x.Loop0320, 8);
            Layout(x => x.Loop0350, 9);
            Layout(x => x.Loop0380, 10);
        }
    }
}