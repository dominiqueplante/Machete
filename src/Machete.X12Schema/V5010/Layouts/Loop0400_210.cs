namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0400_210 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        SegmentList<L5> DescriptionMarksAndNumbers { get; }
        
        SegmentList<H1> HazardousMaterial { get; }
        
        SegmentList<H2> AdditionalHazardousMaterialDescription { get; }
        
        SegmentList<L0> LineItemQuantityAndWeight { get; }
        
        SegmentList<L1> RateAndCharges { get; }
        
        SegmentList<L4> Measurement { get; }
        
        SegmentList<L7> TariffReference { get; }
        
        SegmentList<K1> Remarks { get; }
        
        LayoutList<Loop0430_210> Loop0430 { get; }
        
        LayoutList<Loop0460_210> Loop0460 { get; }
    }
}