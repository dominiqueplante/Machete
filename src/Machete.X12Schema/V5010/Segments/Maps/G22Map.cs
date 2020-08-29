namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class G22Map :
        X12SegmentMap<G22, X12Entity>
    {
        public G22Map()
        {
            Id = "G22";
            Name = "Pre-Pricing Information";
            
            Value(x => x.PrePricedOptionCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.PriceNewSuggestedRetail, 2, x => x.MinLength(2).MaxLength(7));
            Value(x => x.MultiplePriceQuantity, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.FreeformMessage, 4, x => x.MinLength(1).MaxLength(60));
            Value(x => x.Date, 5, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
        }
    }
}