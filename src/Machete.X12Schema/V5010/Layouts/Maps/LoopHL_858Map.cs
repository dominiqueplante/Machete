namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopHL_858Map :
        X12LayoutMap<LoopHL_858, X12Entity>
    {
        public LoopHL_858Map()
        {
            Id = "Loop_HL_858";
            Name = "Loop HL";
            
            Segment(x => x.EquipmentDetails, 0);
            Segment(x => x.EquipmentCharacteristics, 1);
            Segment(x => x.CrossReferenceEquipment, 2);
            Segment(x => x.SealNumbers, 3);
            Segment(x => x.EquipmentOrdered, 4);
            Segment(x => x.ReferenceInformation, 5);
            Segment(x => x.IntermodalChassisEquipment, 6);
            Segment(x => x.MotorVehicleControl, 7);
            Segment(x => x.TariffReference, 8);
            Segment(x => x.TariffDetails, 9);
            Segment(x => x.ExtendedReferenceInformation, 10);
            Segment(x => x.SpecialHandlingInstructions, 11);
            Segment(x => x.ExportLicense, 12);
            Segment(x => x.ImportLicense, 13);
            Segment(x => x.DescriptionMarksAndNumbers, 14);
            Segment(x => x.AdministrativeCommunicationsContact, 15);
            Segment(x => x.HazardousClassificationInformation, 16);
            Segment(x => x.HazardousMaterialIdentifyingReferenceNumbers, 17);
            Segment(x => x.HazardousCertification, 18);
            Segment(x => x.CargoBookingPriority, 19);
            Segment(x => x.DateOrTime, 20);
            Segment(x => x.NotesOrSpecialInstruction, 21);
            Segment(x => x.LoadPlanning, 22);
            Segment(x => x.VehicleAxleMeasurements, 23);
            Layout(x => x.LoopE1, 24);
            Layout(x => x.LoopL0, 25);
            Layout(x => x.LoopLH1, 26);
            Layout(x => x.LoopFA1, 27);
            Layout(x => x.LoopN1, 28);
        }
    }
}