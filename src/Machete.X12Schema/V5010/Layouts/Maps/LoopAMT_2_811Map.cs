namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopAMT_2_811Map :
        X12LayoutMap<LoopAMT_2_811, X12Entity>
    {
        public LoopAMT_2_811Map()
        {
            Id = "Loop_AMT_2_811";
            Name = "Loop AMT";
            
            Segment(x => x.MonetaryAmountInformation, 0);
            Segment(x => x.DateOrTimeReference, 1);
        }
    }
}