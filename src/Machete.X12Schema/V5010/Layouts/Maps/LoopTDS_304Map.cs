namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopTDS_304Map :
        X12LayoutMap<LoopTDS_304, X12Entity>
    {
        public LoopTDS_304Map()
        {
            Id = "Loop_TDS_304";
            Name = "Loop TDS";
            
            Segment(x => x.TotalMonetaryValueSummary, 0);
            Segment(x => x.Currency, 1);
        }
    }
}