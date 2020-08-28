namespace Machete.X12Schema.V5010
{
    using X12;


    public interface M830 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T830> Transactions { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}