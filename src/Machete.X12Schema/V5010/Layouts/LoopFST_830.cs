namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopFST_830 :
        X12Layout
    {
        Segment<FST> ForecastSchedule { get; }
        
        SegmentList<QTY> QuantityInformation { get; }
        
        SegmentList<SDQ> DestinationQuantity { get; }
        
        LayoutList<LoopLM_830> LoopLM { get; }
    }
}