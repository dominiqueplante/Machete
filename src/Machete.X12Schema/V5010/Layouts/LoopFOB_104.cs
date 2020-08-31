namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopFOB_104 :
        X12Layout
    {
        Segment<FOB> FreeOnBoardRelatedInstructions { get; }
        
        Segment<SL1> TariffDetails { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<TD4> CarrierDetailsSpecialHandlingOrHazardousMaterial { get; }
        
        Segment<H1> HazardousMaterial { get; }
        
        Segment<H2> AdditionalHazardousMaterialDescription { get; }
        
        Segment<H3> SpecialHandlingInstructions { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
        
        Segment<M1> Insurance { get; }
        
        Segment<C3> CurrencyIdentifier { get; }
        
        Segment<X1> ExportLicense { get; }
        
        Segment<X2> ImportLicense { get; }
        
        SegmentList<NTE> NotesOrSpecialInstruction { get; }
        
        LayoutList<LoopN1_104> LoopN1 { get; }
        
        LayoutList<LoopL5_104> LoopL5 { get; }
        
        SegmentList<ACS> AncillaryCharges { get; }
    }
}