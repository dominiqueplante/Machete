namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopED_311 :
        X12Layout
    {
        Segment<ED> EquipmentDescription { get; }
        
        SegmentList<M7> SealNumbers { get; }
        
        Segment<NA> CrossReferenceEquipment { get; }
        
        Segment<L4> Measurement { get; }
        
        Segment<G2> BeyondRouting { get; }
    }
}