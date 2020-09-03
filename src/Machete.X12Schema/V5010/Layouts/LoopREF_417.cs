namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopREF_417 :
        X12Layout
    {
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<N10> QuantityAndDescription { get; }
        
        LayoutList<LoopN1_2_417> LoopL0 { get; }
    }
}