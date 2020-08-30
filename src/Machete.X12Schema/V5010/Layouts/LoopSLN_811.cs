namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSLN_811 :
        X12Layout
    {
        Segment<SLN> SublineItemDetail { get; }

        SegmentList<SI> ServiceCharacteristicIdentification { get; }

        SegmentList<PID> ProductItemDescription { get; }

        SegmentList<MEA> Measurements { get; }

        Segment<CUR> Currency { get; }

        Segment<INC> InstallmentInformation { get; }

        SegmentList<ITA> AllowanceChargeOrService { get; }

        SegmentList<TXI> TaxInformation { get; }

        SegmentList<REF> ReferenceInformation { get; }

        SegmentList<PER> AdministrativeCommunicationsContact { get; }

        SegmentList<DTM> DateOrTimeReference { get; }

        SegmentList<AMT> MonetaryAmountInformation { get; }

        SegmentList<MSG> MessageText { get; }

        LayoutList<LoopQTY_811> LoopQTY { get; }

        LayoutList<LoopNM1_3_811> LoopNM1 { get; }
    }
}