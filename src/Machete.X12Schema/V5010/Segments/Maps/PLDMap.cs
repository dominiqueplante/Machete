namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class PLDMap :
        X12SegmentMap<PLD, X12Entity>
    {
        public PLDMap()
        {
            Id = "PLD";
            Name = "Pallet Shipment Information";
            
            Value(x => x.QuantityOfPalletsShipped, 1, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.PalletExchangeCode, 2, x => x.FixedLength(1));
            Value(x => x.WeightUnitCode, 3, x => x.FixedLength(1));
            Value(x => x.Weight, 4, x => x.MinLength(1).MaxLength(10));
        }
    }
}