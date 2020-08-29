namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopBPR_823 :
        X12Layout
    {
        Segment<BPR> BeginningSegmentForPaymentOrderOrRemittanceAdvice { get; }
        
        Segment<TRN> Trace { get; }
        
        Segment<CUR> Currency { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        Segment<AVA> FundsAvailability { get; }

        LayoutList<LoopADX_823> LoopADX { get; }

        LayoutList<LoopN1_823> LoopN1 { get; }

        LayoutList<LoopRMR_823> LoopRMR { get; }

        LayoutList<LoopTXP_823> LoopTXP { get; }

        LayoutList<LoopDED_823> LoopDED { get; }

        LayoutList<LoopLX_823> LoopLX { get; }
    }
}