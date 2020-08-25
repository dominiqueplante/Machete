namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0210_754 :
        X12Layout
    {
        Segment<QTY> QuantityInformation { get; }
        
        Segment<AT9> TrailerOrContainerDimensionAndWeight { get; }
    }
}