namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopDEP_823Map :
        X12LayoutMap<LoopDEP_823, X12Entity>
    {
        public LoopDEP_823Map()
        {
            Id = "Loop_DEP_823";
            Name = "Loop DEP";
            
            Segment(x => x.Deposit, 0);
            Segment(x => x.MonetaryAmountInformation, 1);
            Segment(x => x.QuantityInformation, 2);
            Segment(x => x.ReferenceInformation, 3);
            Segment(x => x.DateOrTimeReference, 4);
            Layout(x => x.LoopBAT, 5);
        }
    }
}