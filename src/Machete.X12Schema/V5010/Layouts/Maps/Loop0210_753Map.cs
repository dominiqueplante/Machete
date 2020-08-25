namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0210_753Map :
        X12LayoutMap<Loop0210_753, X12Entity>
    {
        public Loop0210_753Map()
        {
            Id = "Loop_0210_753";
            Name = "Loop 0210";

            Segment(x => x.OrderInformationDetail, 0);
            Segment(x => x.CommodityClassification, 1);
        }
    }
}