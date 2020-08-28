namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLM_830 :
        X12Layout
    {
        Segment<LM> CodeSourceInformation { get; }
        
        Segment<LQ> IndustryCodeIdentification { get; }
    }
}