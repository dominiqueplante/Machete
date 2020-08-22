namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0320_210 :
        X12Layout
    {
        Segment<N7> EquipmentDetails { get; }
        
        SegmentList<M7> SealNumbers { get; }
    }
}