namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPO4_304Map :
        X12LayoutMap<LoopPO4_304, X12Entity>
    {
        public LoopPO4_304Map()
        {
            Id = "Loop_PO4_304";
            Name = "Loop PO4";
            
            Segment(x => x.ItemPhysicalDetails, 0);
            Segment(x => x.Measurements, 1);
            Segment(x => x.MarksAndNumbersInformation, 2);
            Segment(x => x.ExtendedReferenceInformation, 3);
        }
    }
}