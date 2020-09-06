namespace Machete.X12Schema.V5010
{
    using X12;


    public interface I311 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T311> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}