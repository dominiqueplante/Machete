namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop1000_204Map :
        X12LayoutMap<Loop1000_204, X12Entity>
    {
        public Loop1000_204Map()
        {
            Id = "Loop_1000_204";
            Name = "Loop 0050";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.Measurement, 1);
        }
    }
}