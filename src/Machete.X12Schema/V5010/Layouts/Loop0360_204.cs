namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0360_204 :
        X12Layout
    {
        SegmentList<L5> DescriptionMarksAndNumbers { get; }
        
        Segment<AT8> ShipmentWeightPackagingAndQuantityData { get; }
        
        Segment<L4> Measurement { get; }
        
        LayoutList<Loop0365_204> Loop0365 { get; }
    }
}