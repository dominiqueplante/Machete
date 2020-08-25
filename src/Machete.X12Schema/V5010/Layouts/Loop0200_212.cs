namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0200_212 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        Segment<AT7> ShipmentStatusDetails { get; }
        
        Segment<BLR> TransportationCarrierIdentification { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        Segment<AT8> ShipmentWeightPackagingAndQuantityData { get; }
        
        SegmentList<Q7> LadingExceptionStatus { get; }
        
        Segment<G62> DateOrTime { get; }
        
        Segment<TSD> TrailerShipmentDetails { get; }
        
        LayoutList<Loop0210_212> Loop0210 { get; }
        
        Layout<Loop0220_212> Loop0220 { get; }
    }
}