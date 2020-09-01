namespace Machete.X12Schema.V5010
{
    using X12;


    public interface I300 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T300> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}