namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopL5_104Map :
        X12LayoutMap<LoopL5_104, X12Entity>
    {
        public LoopL5_104Map()
        {
            Id = "Loop_L5_104";
            Name = "Loop L5";

            Segment(x => x.DescriptionMarksAndNumbers, 0);
            Segment(x => x.LineItemQuantityAndWeight, 1);
            Segment(x => x.RateAndCharges, 2);
            Segment(x => x.Measurement, 3);
        }
    }
}