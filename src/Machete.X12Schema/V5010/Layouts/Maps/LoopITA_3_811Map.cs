namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopITA_3_811Map :
        X12LayoutMap<LoopITA_3_811, X12Entity>
    {
        public LoopITA_3_811Map()
        {
            Id = "Loop_ITA_3_811";
            Name = "Loop ITA";
            
            Segment(x => x.AllowanceChargeOrService, 0);
            Segment(x => x.DateOrTimeReference, 1);
            Segment(x => x.MonetaryAmountInformation, 2);
            Segment(x => x.ServiceCharacteristicIdentification, 3);
            Segment(x => x.ReferenceInformation, 4);
            Segment(x => x.Currency, 5);
        }
    }
}