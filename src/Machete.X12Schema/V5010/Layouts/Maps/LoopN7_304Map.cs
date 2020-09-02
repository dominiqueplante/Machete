namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN7_304Map :
        X12LayoutMap<LoopN7_304, X12Entity>
    {
        public LoopN7_304Map()
        {
            Id = "Loop_N7_304";
            Name = "Loop N7";
            
            Segment(x => x.EquipmentDetails, 0);
            Segment(x => x.QuantityInformation, 1);
            Segment(x => x.Measurement, 2);
            Segment(x => x.EquipmentEnvironment, 3);
            Segment(x => x.SealNumbers, 4);
            Segment(x => x.SealNumberReplacement, 5);
            Segment(x => x.EquipmentAndTemperature, 6);
            Segment(x => x.HazardousCertification, 7);
            Layout(x => x.LoopL1, 8);
            Segment(x => x.TariffReference, 9);
            Segment(x => x.ExportLicense, 10);
            Segment(x => x.ImportLicense, 11);
            Segment(x => x.ExtendedReferenceInformation, 12);
            Layout(x => x.LoopH1, 13);
            Layout(x => x.LoopLH1, 14);
        }
    }
}