namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G40Map :
        X12SegmentMap<G40, X12Entity>
    {
        public G40Map()
        {
            Id = "G40";
            Name = "Bracket Price";
            
            Value(x => x.PriceBracketIdentifier, 1, x => x.MinLength(1).MaxLength(3));
            Value(x => x.ItemListCostNew, 2, x => x.MinLength(1).MaxLength(9).IsRequired());
            Value(x => x.ItemListCostOld, 3, x => x.MinLength(1).MaxLength(9));
            Value(x => x.FreeformDescription, 4, x => x.MinLength(1).MaxLength(45));
            Value(x => x.PriceNewSuggestedRetail, 5, x => x.MinLength(2).MaxLength(7));
            Value(x => x.PriceOldSuggestedRetail, 6, x => x.MinLength(2).MaxLength(7));
            Value(x => x.UnitOrBasisForMeasurementCode, 4, x=> x.FixedLength(2));
            Value(x => x.PriceIdentifierCode, 4, x=> x.FixedLength(3));
            Value(x => x.Number, 6, x => x.MinLength(1).MaxLength(9));
        }
    }
}