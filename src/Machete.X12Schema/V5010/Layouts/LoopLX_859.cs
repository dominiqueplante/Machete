namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLX_859 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        LayoutList<LoopN1_859> LoopN1 { get; }
        
        SegmentList<L5> DescriptionMarksAndNumbers { get; }
        
        LayoutList<LoopL0_859> LoopL0 { get; }
        
        Segment<L7> TariffReference { get; }
        
        Segment<SL1> TariffDetails { get; }
        
        Segment<R1> RouteInformationAir { get; }
        
        Segment<LH> MixedHazardousCommodities { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<X1> ExportLicense { get; }
        
        Segment<X2> ImportLicense { get; }
        
        SegmentList<P1> Pickup { get; }
        
        SegmentList<POD> ProofOfDelivery { get; }
        
        Segment<FOB> FreeOnBoardRelatedInstructions { get; }

        SegmentList<ITA> AllowanceChargeOrService { get; }

        Segment<L8> LineItemSubtotal { get; }
        
        Segment<V9> EventDetail { get; }
        
        Segment<P2> DeliveryDateInformation { get; }
        
        SegmentList<N7> EquipmentDetails { get; }
        
        LayoutList<LoopH1_859> LoopLX { get; }
    }
}