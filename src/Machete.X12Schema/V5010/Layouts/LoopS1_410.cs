namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopS1_410 :
        X12Layout
    {
        Segment<S1> StopOffName { get; }
        
        Segment<S2> StopOffAddress { get; }
        
        Segment<S9> StopOffStation { get; }
    }
}