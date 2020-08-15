namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN7_858Map :
        X12LayoutMap<LoopN7_858, X12Entity>
    {
        public LoopN7_858Map()
        {
            Id = "Loop_N7_858";
            Name = "Loop N7";  
            
            Segment(x => x.EquipmentDetails, 0);
            Segment(x => x.EquipmentCharacteristics, 1);
            Segment(x => x.CrossReferenceEquipment, 2);
            Segment(x => x.SealNumbers, 3);
            Segment(x => x.EquipmentOrdered, 4);
            Segment(x => x.DateOrTime, 5);
            Segment(x => x.ReferenceInformation, 6);
            Segment(x => x.IntermodalChassisEquipment, 7);
            Segment(x => x.MotorVehicleControl, 8);
            Segment(x => x.CanadianGrainInformation, 9);
            Layout(x => x.LoopE1, 10);
        }
    }
}