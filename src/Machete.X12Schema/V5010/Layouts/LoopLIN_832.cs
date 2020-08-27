namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLIN_832 :
        X12Layout
    {
        Segment<LIN> ItemIdentification { get; }
        
        Segment<PO1> BaselineItemData { get; }
        
        Segment<G53> MaintenanceType { get;  }
        
        SegmentList<SI> ServiceCharacteristicIdentification { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
        
        SegmentList<YNQ> YesOrNoQuestion { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        SegmentList<CRD> ContentReportingDetail { get; }
        
        SegmentList<CTB> RestrictionsOrConditions { get; }
        
        SegmentList<PID> ProductOrItemDescription { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        SegmentList<PKG> MarkingPackagingOrLoading { get; }
        
        Segment<PO4> ItemPhysicalDetails { get; }
        
        SegmentList<TD1> CarrierDetailsQuantityAndWeight { get; }
        
        SegmentList<TD5> CarrierDetailsRoutingSequenceOrTransitTime { get; }
        
        SegmentList<TD3> CarrierDetailsEquipment { get; }
        
        SegmentList<TD4> CarrierDetailsSpecialHandlingOrHazardousMaterial { get; }
        
        SegmentList<ITD> TermsOfSale { get; }

        SegmentList<LDT> LeadTime { get; }
        
        Segment<SAC> ServicePromotionAllowanceOrChargeInformation { get; }
        
        Segment<FOB> FreeOnBoardRelatedInstructions { get; }
        
        SegmentList<AAA> RequestValidation { get; }
        
        SegmentList<TC2> Commodity { get; }

        SegmentList<TXI> TaxInformation { get; }
        
        SegmentList<MTX> Text { get; }
        
        Segment<G55> ItemCharacteristicsConsumerUnit { get; }
        
        SegmentList<G54> ModuleDescription { get; }
        
        Segment<TSD> TrailerShipmentDetails { get; }
        
        LayoutList<LoopCTP_832> LoopCTP { get; }
        
        LayoutList<LoopN1_3_832> LoopN1 { get; }
        
        LayoutList<LoopG39_832> LoopG39 { get; }
        
        LayoutList<LoopPKL_832> LoopPKL { get; }
        
        LayoutList<LoopLFG_832> LoopLFG { get; }
        
        LayoutList<LoopLM_832> LoopLM { get; }
        
        LayoutList<LoopSLN_832> LoopSLN { get; }
        
        LayoutList<LoopN9_832> LoopN9 { get; }
    }
}