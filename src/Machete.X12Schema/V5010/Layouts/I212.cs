namespace Machete.X12Schema.V5010
{
    using X12;


    public interface I212 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T212> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}