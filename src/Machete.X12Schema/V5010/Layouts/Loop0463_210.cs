namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0463_210 :
        X12Layout
    {
        Segment<CD3> CartonPackageDetail { get; }
        
        Segment<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        SegmentList<H6> SpecialServices { get; }
        
        SegmentList<L9> ChargeDetail { get; }
        
        SegmentList<POD> ProofOfDelivery { get; }
        
        SegmentList<G62> DateOrTime { get; }
    }
}