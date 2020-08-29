namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSAC_823 :
        X12Layout
    {
        Segment<SAC> ServicePromotionAllowanceOrChargeInformation { get; }

        SegmentList<TXI> TaxInformation { get; }
    }
}