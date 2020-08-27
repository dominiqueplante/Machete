namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopCRC_832Map :
        X12LayoutMap<LoopCRC_832, X12Entity>
    {
        public LoopCRC_832Map()
        {
            Id = "Loop_CRC_832";
            Name = "Loop CRC";
            
            Segment(x => x.ConditionsIndicator, 0);
            Segment(x => x.QuantityInformation, 1);
        }
    }
}