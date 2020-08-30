namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopAMT_831 :
        X12Layout
    {
        Segment<AMT> MonetaryAmountInformation { get; }
        
        Segment<QTY> QuantityInformation { get; }
    }
}