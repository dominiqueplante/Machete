namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T214 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<B10> BeginningTransportationCarrierShipmentStatusMessage { get; }
        
        SegmentList<MS3> InterlineInformation { get; }
        
        LayoutList<Loop1000_214> Loop1000 { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}