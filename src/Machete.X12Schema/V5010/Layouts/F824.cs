namespace Machete.X12Schema.V5010
{
    using X12;


    public interface F824 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T824> Transactions { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}