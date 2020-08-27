namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopCTP_832 :
        X12Layout
    {
        Segment<CTP> PricingInformation { get; }

        SegmentList<DTM> DateOrTimeReference { get; }
        
        Segment<G36> PriceListReference { get; }

        SegmentList<LDT> LeadTime { get; }

        SegmentList<CUR> Currency { get; }
        
        Segment<PO4> ItemPhysicalDetails { get; }
        
        SegmentList<CTB> RestrictionsOrConditions { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<G43> PromotionOrPriceListArea { get; }

        Segment<SAC> ServicePromotionAllowanceOrChargeInformation { get; }
        
        SegmentList<G26> PricingConditions { get; }

        SegmentList<TXI> TaxInformation { get; }
        
        SegmentList<ITD> TermsOfSale { get; }
        
        LayoutList<LoopG40_832> LoopG40 { get; }
        
        Segment<LS> LoopHeader { get; }
        
        LayoutList<LoopLM_1_832> LoopLM { get; }
        
        Segment<LE> LoopTrailer { get; }
        
        LayoutList<LoopN1_2_832> LoopN1 { get; }
    }
}