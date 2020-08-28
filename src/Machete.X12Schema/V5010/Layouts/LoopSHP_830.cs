namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSHP_830 :
        X12Layout
    {
        Segment<SHP> ShippedOrReceivedInformation { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
    }
}