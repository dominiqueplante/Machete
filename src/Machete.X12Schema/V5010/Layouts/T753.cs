namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T753 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BGN> BeginningTransportationCarrierShipmentStatusMessage { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        Layout<Loop0100_753> Loop0100 { get; }
        
        Segment<LX> TransactionSetLineNumber { get; }
        
        LayoutList<Loop0200_753> Loop0200 { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}