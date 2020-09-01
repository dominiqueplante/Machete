namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLX_301Map :
        X12LayoutMap<LoopLX_301, X12Entity>
    {
        public LoopLX_301Map()
        {
            Id = "Loop_LX_301";
            Name = "Loop LX";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.EquipmentDetails, 1);
            Segment(x => x.EquipmentAndTemperature, 2);
            Segment(x => x.Remarks, 3);
            Segment(x => x.LineItemQuantityAndWeight, 4);
            Segment(x => x.DescriptionMarksAndNumbers, 5);
            Segment(x => x.Measurement, 6);
            Segment(x => x.RateAndCharges, 7);
            Layout(x => x.LoopH1, 8);
            Layout(x => x.LoopLH1, 9);
        }
    }
}