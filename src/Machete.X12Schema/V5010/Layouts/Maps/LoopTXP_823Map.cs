namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopTXP_823Map :
        X12LayoutMap<LoopTXP_823, X12Entity>
    {
        public LoopTXP_823Map()
        {
            Id = "Loop_TXP_823";
            Name = "Loop TXP";
            
            Segment(x => x.TaxPayment, 0);
            Segment(x => x.TaxInformation, 1);
        }
    }
}