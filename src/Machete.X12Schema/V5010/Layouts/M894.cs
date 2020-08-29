namespace Machete.X12Schema.V5010
{
    using X12;


    public interface M894 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T894> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}