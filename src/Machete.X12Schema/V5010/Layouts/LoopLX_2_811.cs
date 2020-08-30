namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLX_2_811 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }

        Segment<REF> ReferenceInformation { get; }

        LayoutList<LoopAMT_2_811> LoopAMT { get; }

        LayoutList<LoopITA_4_811> LoopITA { get; }
    }
}