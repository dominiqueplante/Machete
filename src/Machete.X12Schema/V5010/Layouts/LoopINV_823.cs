namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopINV_823 :
        X12Layout
    {
        Segment<INV> InvestmentVehicleSelection { get; }
        
        SegmentList<DTP> DateOrTimeOrPeriod { get; }
    }
}