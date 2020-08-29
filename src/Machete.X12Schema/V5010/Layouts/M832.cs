namespace Machete.X12Schema.V5010
{
    using X12;


    public interface M832 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T832> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}