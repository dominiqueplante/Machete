namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0380_204 :
        X12Layout
    {
        Segment<N7> EquipmentDetails { get; }
        
        Segment<N7A> AccessorialEquipmentDetails { get; }
        
        Segment<N7B> AdditionalEquipmentDetails { get; }
        
        Segment<MEA> Measurements { get; }
        
        SegmentList<M7> SealNumbers { get; }
    }
}