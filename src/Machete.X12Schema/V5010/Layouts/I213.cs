namespace Machete.X12Schema.V5010
{
    using X12;


    public interface I213 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T213> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}