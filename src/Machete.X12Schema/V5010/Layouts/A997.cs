namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 997 Functional Acknowledgment for Healthcare Insurance
    /// </summary>
    public interface A997 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T997> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}