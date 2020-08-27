namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopG40_832 :
        X12Layout
    {
        Segment<G40> BracketPrice { get; }

        Segment<SAC> ServicePromotionAllowanceOrChargeInformation { get; }
        
        SegmentList<G93> PriceBracketIdentification { get; }
    }
}