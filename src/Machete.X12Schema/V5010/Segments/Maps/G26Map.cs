namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G26Map :
        X12SegmentMap<G26, X12Entity>
    {
        public G26Map()
        {
            Id = "G26";
            Name = "Pricing Conditions";
            
            Value(x => x.PriceConditionCode, 1, x=> x.FixedLength(2).IsRequired());
            Value(x => x.DateQualifier, 2, x=> x.FixedLength(2));
            Value(x => x.Date, 3, x =>
            {
                x.FixedLength(8);
            });
            Value(x => x.QuantityBasis, 4, x=> x.FixedLength(3));
            Value(x => x.Quantity, 5, x => x.MinLength(1).MaxLength(15));
            Value(x => x.UnitOrBasisForMeasurementCode, 6, x => x.FixedLength(2));
        }
    }
}