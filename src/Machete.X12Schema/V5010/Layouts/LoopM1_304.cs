namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopM1_304 :
        X12Layout
    {
        Segment<M1> Insurance { get; }
        
        Segment<CUR> Currency { get; }
    }
}