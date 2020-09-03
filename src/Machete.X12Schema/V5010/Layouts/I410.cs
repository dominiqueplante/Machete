namespace Machete.X12Schema.V5010
{
    using X12;


    public interface I410 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T315> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}