namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopL1_310 :
        X12Layout
    {
        Segment<L1> RateAndCharges { get; }
        
        Segment<C3> CurrencyIdentifier { get; }
    }
}