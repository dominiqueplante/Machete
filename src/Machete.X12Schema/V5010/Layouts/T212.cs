namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T212 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<B3> BeginningMotorCarrierDeliveryTrailerManifest { get; }
        
        Segment<B2A> SetPurpose { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        Layout<Loop0100_212> Loop0100 { get; }
        
        Layout<Loop0150_212> Loop0150 { get; }
        
        LayoutList<Loop0200_212> Loop0200 { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}