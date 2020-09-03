namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN7_410Map :
        X12LayoutMap<LoopN7_410, X12Entity>
    {
        public LoopN7_410Map()
        {
            Id = "Loop_N7_410";
            Name = "Loop N7";
            
            Segment(x => x.EquipmentDetails, 0);
            Segment(x => x.MotorVehicleControl, 1);
            Segment(x => x.ScaleIdentification, 2);
            Segment(x => x.SealNumbers, 3);
            Segment(x => x.EquipmentOrdered, 4);
            Segment(x => x.IntermodalChassisEquipment, 5);
            Segment(x => x.IntermodalMovementInformation, 6);
            Segment(x => x.InbondIdentifyingInformation, 7);
            Segment(x => x.CanadianGrainInformation, 8);
        }
    }
}