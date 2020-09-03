namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopVC_417 :
        X12Layout
    {
        Segment<VC> MotorVehicleControl { get; }
        
        LayoutList<LoopN1_1_417> LoopL0 { get; }
    }
}