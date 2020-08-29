namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopAIN_823 :
        X12Layout
    {
        Segment<AIN> Income { get; }
        
        SegmentList<QTY> QuantityInformation { get; }
        
        SegmentList<DTP> DateOrTimeOrPeriod { get; }
    }
}