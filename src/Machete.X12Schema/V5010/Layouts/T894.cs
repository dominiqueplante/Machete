namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T894 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }

        SegmentList<G82> DeliveryOrReturnBaseRecordIdentifier { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        Segment<LS> LoopHeader { get; }
        
        LayoutList<Loop0100_894> Loop0100 { get; }
        
        Segment<LE> LoopTrailer { get; }
        
        SegmentList<G72> AllowanceOrCharge { get; }

        SegmentList<G23> TermsOfSale { get; }

        SegmentList<G84> DeliveryOrReturnBaseRecordOfTotals { get; }

        Segment<G86> SignatureIdentification { get; }

        Segment<G85> RecordIntegrityCheck { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}