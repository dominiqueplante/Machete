namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0210_753 :
        X12Layout
    {
        Segment<OID> OrderInformationDetail { get; }
        
        Segment<CMC> CommodityClassification { get; }
    }
}