namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopITA_4_811 :
        X12Layout
    {
        Segment<ITA> AllowanceChargeOrService { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
    }
}