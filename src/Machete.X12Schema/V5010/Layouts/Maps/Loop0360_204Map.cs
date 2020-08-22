namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0360_204Map :
        X12LayoutMap<Loop0360_204, X12Entity>
    {
        public Loop0360_204Map()
        {
            Id = "Loop_0360_204";
            Name = "Loop 0360";
            
            Segment(x => x.DescriptionMarksAndNumbers, 0);
            Segment(x => x.ShipmentWeightPackagingAndQuantityData, 1);
            Segment(x => x.Measurement, 2);
            Layout(x => x.Loop0365, 3);
        }
    }
}