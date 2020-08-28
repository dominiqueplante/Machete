namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T832 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }

        SegmentList<BCT> BeginningSegmentForPriceOrSalesCatalog { get; }
        
        SegmentList<CTP> PricingInformation { get; }
        
        SegmentList<REF> ReferenceInformation { get; }

        SegmentList<YNQ> YesNoQuestion { get; }

        SegmentList<PER> AdministrativeCommunicationsContact { get; }

        SegmentList<DTM> DateOrTimeReference { get; }
        
        SegmentList<CTB> RestrictionsOrConditions { get; }

        SegmentList<CUR> Currency { get; }
        
        SegmentList<ITD> TermsOfSale { get; }

        SegmentList<LDT> LeadTime { get; }

        Segment<SAC> ServicePromotionAllowanceOrChargeInformation { get; }
        
        SegmentList<TD1> CarrierDetailsQuantityAndWeight { get; }
        
        SegmentList<TD5> CarrierDetailsRoutingSequenceOrTransitTime { get; }
        
        SegmentList<TD3> CarrierDetailsEquipment { get; }
        
        SegmentList<TD4> CarrierDetailsSpecialHandlingOrHazardousMaterial { get; }
        
        Segment<FOB> FreeOnBoardRelatedInstructions { get; }
        
        SegmentList<PKG> MarkingPackagingOrLoading { get; }

        SegmentList<TXI> TaxInformation { get; }
        
        Segment<AAA> RequestValidation { get; }
        
        SegmentList<PWK> Paperwork { get; }
        
        SegmentList<MTX> Text { get; }

        LayoutList<LoopN1_1_832> LoopN1 { get; }

        LayoutList<LoopLM_1_832> LoopLM { get; }

        LayoutList<LoopN9_832> LoopN9 { get; }

        LayoutList<LoopG93_832> LoopG93 { get; }

        LayoutList<LoopLIN_832> LoopLIN { get; }

        Segment<CTT> TransactionTotals { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}