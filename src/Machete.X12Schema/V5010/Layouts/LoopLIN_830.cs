namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLIN_830 :
        X12Layout
    {
        Segment<LIN> ItemIdentification { get; }
        
        Segment<UIT> UnitDetail { get; }

        SegmentList<DTM> DateOrTimeReference { get; }
        
        Segment<CUR> Currency { get; }
        
        SegmentList<PO3> AdditionalItemDetail { get; }
        
        SegmentList<CTP> PricingInformation { get; }
        
        SegmentList<PID> ProductOrItemDescription { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        SegmentList<PWK> Paperwork { get; }
        
        SegmentList<PKG> MarkingPackagingOrLoading { get; }
        
        SegmentList<PO4> ItemPhysicalDetails { get; }
        
        Segment<PRS> PartReleaseStatus { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        Segment<SAC> ServicePromotionAllowanceOrChargeInformation { get; }
        
        SegmentList<ITD> TermsOfSale { get; }
        
        SegmentList<TAX> TaxReference { get; }
        
        Segment<FOB> FreeOnBoardRelatedInstructions { get; }
        
        Segment<LDT> LeadTime { get; }
        
        SegmentList<QTY> QuantityInformation { get; }
        
        SegmentList<ATH> ResourceAuthorization { get; }

        SegmentList<TD1> CarrierDetailsQuantityAndWeight { get; }
        
        SegmentList<TD5> CarrierDetailsRoutingSequenceOrTransitTime { get; }
        
        SegmentList<TD3> CarrierDetailsEquipment { get; }
        
        SegmentList<TD4> CarrierDetailsSpecialHandlingOrHazardousMaterial { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        SegmentList<DD> DemandDetail { get; }

        LayoutList<LoopSLN_830> LoopSLN { get; }

        LayoutList<LoopN1_830> LoopN1 { get; }

        LayoutList<LoopLM_830> LoopLM { get; }

        LayoutList<LoopFST_830> LoopFST { get; }

        LayoutList<LoopSDP_830> LoopSDP { get; }

        LayoutList<LoopSHP_830> LoopSHP { get; }
    }
}