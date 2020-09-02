namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopL0_304Map :
        X12LayoutMap<LoopL0_304, X12Entity>
    {
        public LoopL0_304Map()
        {
            Id = "Loop_L0_304";
            Name = "Loop L0";
            
            Segment(x => x.LineItemQuantityAndWeight, 0);
            Segment(x => x.Measurements, 1);
            Segment(x => x.ExtendedReferenceInformation, 2);
            Layout(x => x.LoopPO4, 3);
            Segment(x => x.QuantityInformation, 4);
            Segment(x => x.Measurement, 5);
            Segment(x => x.HazardousCertification, 6);
            Layout(x => x.LoopPAL, 7);
            Layout(x => x.LoopCTP, 8);
            Segment(x => x.DescriptionMarksAndNumbers, 9);
            Segment(x => x.ItemIdentification, 10);
            Segment(x => x.AlternateLadingDescription, 11);
            Segment(x => x.YesNoQuestion, 12);
            Layout(x => x.LoopL1, 13);
            Segment(x => x.TariffReference, 14);
            Layout(x => x.LoopSAC, 15);
            Layout(x => x.LoopL9, 16);
            Segment(x => x.ExportLicense, 17);
            Segment(x => x.ImportLicense, 18);
            Layout(x => x.LoopC8, 19);
            Layout(x => x.LoopH1, 20);
            Layout(x => x.LoopLH1, 21);
            Layout(x => x.LoopN1, 22);
        }
    }
}