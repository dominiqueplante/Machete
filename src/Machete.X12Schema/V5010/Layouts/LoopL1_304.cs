namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopL1_304 :
        X12Layout
    {
        Segment<L1> RateAndCharges { get; }
        
        Segment<CUR> Currency { get; }
    }
}