namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopIT1_811 :
        X12Layout
    {
        Segment<IT1> BaseLineItemData { get; }

        SegmentList<SI> ServiceCharacteristicInformation { get; }

        SegmentList<PID> ProductItemDescription { get; }

        SegmentList<MEA> Measurements { get; }

        Segment<INC> InstallmentInformation { get; }

        SegmentList<TXI> TaxInformation { get; }

        SegmentList<REF> ReferenceInformation { get; }

        SegmentList<DTM> DateTimeReference { get; }

        SegmentList<MSG> MessageText { get; }

        Segment<CAD> CarrierDetails { get; }

        SegmentList<YNQ> YesNoQuestion { get; }

        SegmentList<LQ> IndustryCodeIdentification { get; }

        SegmentList<LCD> PlaceLocationDescription { get; }

        LayoutList<LoopAMT_1_811> LoopAMT { get; }

        LayoutList<LoopQTY_811> LoopQTY { get; }

        LayoutList<LoopITA_1_811> LoopITA { get; }

        LayoutList<LoopNM1_2_811> LoopNM1 { get; }
    }
}