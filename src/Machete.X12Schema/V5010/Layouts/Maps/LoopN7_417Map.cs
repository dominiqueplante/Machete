namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN7_417Map :
        X12LayoutMap<LoopN7_417, X12Entity>
    {
        public LoopN7_417Map()
        {
            Id = "Loop_N7_417";
            Name = "Loop N7";
            
            Segment(x => x.EquipmentDetails, 0);
            Segment(x => x.EquipmentCharacteristics, 1);
            Layout(x => x.LoopVC, 2);
            Segment(x => x.IntermodalChassisEquipment, 3);
            Segment(x => x.IntermodalMovementInformation, 4);
            Segment(x => x.InbondIdentifyingInformation, 5);
            Segment(x => x.ScaleIdentification, 6);
            Segment(x => x.SealNumbers, 7);
            Segment(x => x.EquipmentOrdered, 8);
            Segment(x => x.CarServiceOrder, 9);
            Layout(x => x.LoopE1, 10);
            Segment(x => x.CanadianGrainInformation, 11);
            Layout(x => x.LoopREF, 12);
            Segment(x => x.InterchangeMoveAuthority, 13);
        }
    }
}