namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopAMT_1_811Map :
        X12LayoutMap<LoopAMT_1_811, X12Entity>
    {
        public LoopAMT_1_811Map()
        {
            Id = "Loop_AMT_1_811";
            Name = "Loop AMT";
            
            Segment(x => x.MonetaryAmountInformation, 0);
            Segment(x => x.Currency, 1);
        }
    }
}