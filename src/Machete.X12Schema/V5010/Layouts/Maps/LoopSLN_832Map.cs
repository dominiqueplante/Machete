namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSLN_832Map :
        X12LayoutMap<LoopSLN_832, X12Entity>
    {
        public LoopSLN_832Map()
        {
            Id = "Loop_SLN_832";
            Name = "Loop SLN";
            
            Segment(x => x.SublineItemDetail, 0);
            Segment(x => x.ServiceCharacteristicIdentification, 1);
            Segment(x => x.ItemDescription, 2);
            Segment(x => x.DateOrTimeReference, 3);
            Segment(x => x.PricingInformation, 4);
            Segment(x => x.PeriodAmount, 5);
            Segment(x => x.ItemPhysicalDetails, 6);
            Segment(x => x.MarkingPackagingOrLoading, 7);
            Segment(x => x.QuantityInformation, 8);
            Segment(x => x.Measurements, 9);
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 10);
            Segment(x => x.ItemDescription, 11);
            Segment(x => x.Text, 12);
            Layout(x => x.LoopLM, 13);
            Layout(x => x.LoopN1, 14);
        }
    }
}