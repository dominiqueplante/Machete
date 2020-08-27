namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopG93_832 :
        X12Layout
    {
        Segment<G93> PriceBracketIdentification { get; }
        
        Segment<SAC> ServicePromotionAllowanceOrChargeInformation { get; }
        
        Segment<N1> PartyIdentification { get; }
        
        Segment<G26> PricingConditions { get; }
    }
}