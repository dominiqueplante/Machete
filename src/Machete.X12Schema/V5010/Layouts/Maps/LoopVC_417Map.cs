namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopVC_417Map :
        X12LayoutMap<LoopVC_417, X12Entity>
    {
        public LoopVC_417Map()
        {
            Id = "Loop_VC_417";
            Name = "Loop VC";
            
            Segment(x => x.MotorVehicleControl, 0);
            Layout(x => x.LoopL0, 1);
        }
    }
}