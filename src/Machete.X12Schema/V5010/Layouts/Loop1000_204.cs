namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop1000_204 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        Segment<L4> Measurement { get; }
    }
}