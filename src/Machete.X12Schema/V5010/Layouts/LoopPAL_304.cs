namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopPAL_304 :
        X12Layout
    {
        Segment<PAL> PalletTypeAndLoadCharacteristics { get; }
        
        SegmentList<QTY> QuantityInformation { get; }
    }
}