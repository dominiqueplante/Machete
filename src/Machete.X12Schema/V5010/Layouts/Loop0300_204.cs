namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0300_204 :
        X12Layout
    {
        Segment<S5> StopOffDetails { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        Segment<AT8> ShipmentWeightPackagingAndQuantityData { get; }
        
        SegmentList<LAD> LadingDetail { get; }
        
        LayoutList<Loop0305_204> Loop0305 { get; }
        
        Segment<PLD> PalletShipmentInformation { get; }
        
        SegmentList<NTE> NotesOrSpecialInstruction { get; }
        
        LayoutList<Loop0310_204> Loop0310 { get; }
        
        LayoutList<Loop0320_204> Loop0320 { get; }
        
        LayoutList<Loop0350_204> Loop0350 { get; }
        
        LayoutList<Loop0380_204> Loop0380 { get; }
    }
}