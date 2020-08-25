namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0210_212 :
        X12Layout
    {
        Segment<OID> OrderInformationDetail { get; }
        
        SegmentList<SDQ> DestinationQuantity { get; }
    }
}