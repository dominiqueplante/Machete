namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopM1_304Map :
        X12LayoutMap<LoopM1_304, X12Entity>
    {
        public LoopM1_304Map()
        {
            Id = "Loop_M1_304";
            Name = "Loop M1";
            
            Segment(x => x.Insurance, 0);
            Segment(x => x.Currency, 1);
        }
    }
}