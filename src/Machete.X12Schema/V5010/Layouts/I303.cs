namespace Machete.X12Schema.V5010
{
    using X12;


    public interface I303 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T303> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}