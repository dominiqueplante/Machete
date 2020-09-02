namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopTDS_304 :
        X12Layout
    {
        Segment<TDS> TotalMonetaryValueSummary { get; }
        
        Segment<CUR> Currency { get; }
    }
}