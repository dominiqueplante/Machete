namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G93Map :
        X12SegmentMap<G93, X12Entity>
    {
        public G93Map()
        {
            Id = "G93";
            Name = "Price Bracket Identification";
            
            Value(x => x.PriceBracketIdentifier, 1, x => x.MinLength(1).MaxLength(3));
            Value(x => x.Quantity, 2, x => x.MinLength(1).MaxLength(15));
            Value(x => x.UnitOrBasisForMeasurementCode, 3, x => x.FixedLength(2));
            Value(x => x.FreeformDescription, 4, x => x.MinLength(1).MaxLength(45));
            Value(x => x.TransportationMethodOrTypeCode, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.PriceIdentifierCode, 6, x=> x.FixedLength(3));
            Value(x => x.ActionCode, 7, x => x.MinLength(1).MaxLength(2));
            Value(x => x.YesNoConditionOrResponseCode, 8, x => x.FixedLength(1));
        }
    }
}