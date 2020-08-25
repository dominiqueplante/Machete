namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0210_754Map :
        X12LayoutMap<Loop0210_754, X12Entity>
    {
        public Loop0210_754Map()
        {
            Id = "Loop_0210_754";
            Name = "Loop 0210";

            Segment(x => x.QuantityInformation, 0);
            Segment(x => x.TrailerOrContainerDimensionAndWeight, 1);
        }
    }
}