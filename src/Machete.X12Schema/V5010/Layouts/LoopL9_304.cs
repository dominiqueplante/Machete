namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopL9_304 :
        X12Layout
    {
        Segment<L9> ChargeDetail { get; }
        
        Segment<CUR> Currency { get; }
    }
}