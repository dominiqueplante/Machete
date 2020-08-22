namespace Machete.X12Schema.V5010
{
    using X12;


    public interface PLD :
        X12Segment
    {
        Value<int> QuantityOfPalletsShipped { get; }
        
        Value<string> PalletExchangeCode { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<decimal> Weight { get; }
    }
}