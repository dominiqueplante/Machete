namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T895 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }

        Segment<G87> DeliveryOrReturnAdjustmentIdentification { get; }
        
        Segment<G88> DeliveryOrReturnIdentificationAdjustment { get; }
        
        Segment<LS> LoopHeader { get; }
        
        LayoutList<Loop0100_895> Loop0100 { get; }
        
        Segment<LE> LoopTrailer { get; }
        
        SegmentList<G72> AllowanceOrCharge { get; }

        SegmentList<G23> TermsOfSale { get; }

        Segment<G84> DeliveryOrReturnBaseRecordOfTotals { get; }

        Segment<G86> SignatureIdentification { get; }

        Segment<G85> RecordIntegrityCheck { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}