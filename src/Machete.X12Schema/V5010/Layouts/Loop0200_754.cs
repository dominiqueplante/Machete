namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0200_754 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        Segment<BLR> TransportationCarrierIdentification { get; }
        
        SegmentList<SMD> ConsolidatedShipmentManifestData { get; }
        
        SegmentList<OID> OrderInformationDetail { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        Segment<MS1> EquipmentShipmentOrRealPropertyLocation { get; }
        
        LayoutList<Loop0210_754> Loop0210 { get; }
        
        Layout<Loop0220_754> Loop0220 { get; }
    }
}