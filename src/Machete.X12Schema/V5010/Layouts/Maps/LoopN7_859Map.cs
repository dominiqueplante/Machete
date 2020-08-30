namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN7_859Map :
        X12LayoutMap<LoopN7_859, X12Entity>
    {
        public LoopN7_859Map()
        {
            Id = "Loop_N7_859";
            Name = "Loop N7";
            
            Segment(x => x.EquipmentDetails, 0);
            Segment(x => x.SealNumbers, 1);
            Segment(x => x.EquipmentOrdered, 2);
            Segment(x => x.ReferenceInformation, 3);
            Segment(x => x.IntermodalChassisEquipment, 4);
            Segment(x => x.MotorVehicleControl, 4);
            Segment(x => x.ScaleIdentification, 4);
            Segment(x => x.CanadianGrainInformation, 4);
        }
    }
}