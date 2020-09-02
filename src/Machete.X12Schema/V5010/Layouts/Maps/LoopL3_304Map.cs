namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopL3_304Map :
        X12LayoutMap<LoopL3_304, X12Entity>
    {
        public LoopL3_304Map()
        {
            Id = "Loop_L3_304";
            Name = "Loop L3";
            
            Segment(x => x.TotalWeightAndCharges, 0);
            Segment(x => x.Currency, 1);
            Segment(x => x.Measurements, 2);
            Segment(x => x.Paperwork, 3);
            Segment(x => x.SupplementaryInformation, 4);
            Layout(x => x.LoopL1, 5);
            Layout(x => x.LoopTDS, 6);
            Layout(x => x.LoopSAC, 7);
            Layout(x => x.LoopL9, 8);
            Segment(x => x.InvoiceShipmentSummary, 9);
            Segment(x => x.EventDetail, 10);
            Segment(x => x.Remarks, 11);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 12);
        }
    }
}