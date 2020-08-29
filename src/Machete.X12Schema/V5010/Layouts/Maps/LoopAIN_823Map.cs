namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopAIN_823Map :
        X12LayoutMap<LoopAIN_823, X12Entity>
    {
        public LoopAIN_823Map()
        {
            Id = "Loop_AIN_823";
            Name = "Loop AIN";
            
            Segment(x => x.Income, 0);
            Segment(x => x.QuantityInformation, 1);
            Segment(x => x.DateOrTimeOrPeriod, 2);
        }
    }
}