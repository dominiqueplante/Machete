namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopCRC_832 :
        X12Layout
    {
        Segment<CRC> ConditionsIndicator { get; }
        
        Segment<QTY> QuantityInformation { get; }
    }
}