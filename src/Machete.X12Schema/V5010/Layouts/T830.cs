namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T830 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }

        Segment<ST> TransactionSetHeader { get; }

        SegmentList<BFR> BeginningSegmentForPlanningSchedule { get; }
        
        SegmentList<XPO> PreassignedPurchaseOrderNumbers { get; }
        
        Segment<CUR> Currency { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        SegmentList<TAX> TaxReference { get; }
        
        Segment<FOB> FreeOnBoardRelatedInstructions { get; }
        
        SegmentList<CTP> PricingInformation { get; }
        
        Segment<SAC> ServicePromotionAllowanceOrChargeInformation { get; }
        
        Segment<CSH> SalesRequirements { get; }
        
        SegmentList<ITD> TermsOfSale { get; }

        SegmentList<DTM> DateOrTimeReference { get; }
        
        SegmentList<PID> ProductOrItemDescription { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        SegmentList<PWK> Paperwork { get; }
        
        SegmentList<PKG> MarkingPackagingOrLoading { get; }

        SegmentList<TD1> CarrierDetailsQuantityAndWeight { get; }
        
        SegmentList<TD5> CarrierDetailsRoutingSequenceOrTransitTime { get; }
        
        SegmentList<TD3> CarrierDetailsEquipment { get; }
        
        SegmentList<TD4> CarrierDetailsSpecialHandlingOrHazardousMaterial { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }

        LayoutList<LoopN1_830> LoopN1 { get; }

        LayoutList<LoopLM_830> LoopLM { get; }

        LayoutList<LoopLIN_830> LoopLIN { get; }

        Segment<CTT> TransactionTotals { get; }

        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}