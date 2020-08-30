namespace Machete.X12Schema.V5010
{
    using X12;


    public interface I859 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T859> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}