namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0325_1_204 :
        X12Layout
    {
        Segment<AT5> BillOfLadingHandlingRequirements { get; }
        
        Segment<RTT> FreightRateInformation { get; }
        
        Segment<C3> CurrencyIdentifier { get; }
    }
}