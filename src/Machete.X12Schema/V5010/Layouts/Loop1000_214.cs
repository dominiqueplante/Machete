namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop1000_214 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        SegmentList<Q7> LadingExceptionStatus { get; }
        
        SegmentList<K1> Remarks { get; }
        
        Segment<AT5> BillOfLadingHandlingRequirements { get; }
        
        Segment<AT8> ShipmentWeightPackagingAndQuantityData { get; }
        
        LayoutList<Loop1100_214> Loop1100 { get; }
        
        LayoutList<Loop1200_214> Loop1200 { get; }
        
        LayoutList<Loop1300_214> Loop1300 { get; }
    }
}