namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopINV_823Map :
        X12LayoutMap<LoopINV_823, X12Entity>
    {
        public LoopINV_823Map()
        {
            Id = "Loop_INV_823";
            Name = "Loop INV";
            
            Segment(x => x.InvestmentVehicleSelection, 0);
            Segment(x => x.DateOrTimeOrPeriod, 1);
        }
    }
}