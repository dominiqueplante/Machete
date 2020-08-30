namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopAMT_1_811 :
        X12Layout
    {
        Segment<AMT> MonetaryAmountInformation { get; }

        Segment<CUR> Currency { get; }
    }
}