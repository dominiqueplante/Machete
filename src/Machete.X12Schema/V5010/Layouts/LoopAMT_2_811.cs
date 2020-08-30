namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopAMT_2_811 :
        X12Layout
    {
        Segment<AMT> MonetaryAmountInformation { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
    }
}