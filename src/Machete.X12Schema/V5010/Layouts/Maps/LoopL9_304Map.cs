namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopL9_304Map :
        X12LayoutMap<LoopL9_304, X12Entity>
    {
        public LoopL9_304Map()
        {
            Id = "Loop_L9_304";
            Name = "Loop L9";
            
            Segment(x => x.ChargeDetail, 0);
            Segment(x => x.Currency, 1);
        }
    }
}