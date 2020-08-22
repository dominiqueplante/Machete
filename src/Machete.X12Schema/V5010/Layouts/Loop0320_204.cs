namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0320_204 :
        X12Layout
    {
        SegmentList<L5> DescriptionMarksAndNumbers { get; }
        
        Segment<AT8> ShipmentWeightPackagingAndQuantityData { get; }
        
        LayoutList<Loop0325_1_204> Loop0325_1 { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        Segment<L4> Measurement { get; }
        
        LayoutList<Loop0325_2_204> Loop0325_2 { get; }
    }
}