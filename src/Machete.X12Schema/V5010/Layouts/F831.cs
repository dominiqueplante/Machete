namespace Machete.X12Schema.V5010
{
    using X12;


    public interface F831 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T831> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}