namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN7_310Map :
        X12LayoutMap<LoopN7_310, X12Entity>
    {
        public LoopN7_310Map()
        {
            Id = "Loop_N7_310";
            Name = "Loop N7";
            
            Segment(x => x.EquipmentDetails, 0);
            Segment(x => x.QuantityInformation, 1);
            Segment(x => x.CargoLocationReference, 2);
            Segment(x => x.EquipmentEnvironment, 3);
            Segment(x => x.SealNumbers, 4);
            Segment(x => x.EquipmentAndTemperature, 5);
            Segment(x => x.TariffReference, 6);
            Segment(x => x.ExportLicense, 7);
            Segment(x => x.ImportLicense, 8);
            Segment(x => x.ExtendedReferenceInformation, 9);
            Layout(x => x.LoopH1, 10);
            Layout(x => x.LoopLH1, 11);
            Segment(x => x.Measurement, 12);
            Segment(x => x.HazardousCertification, 13);
            Layout(x => x.LoopL1, 14);
        }
    }
}