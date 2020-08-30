namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class TIAMap :
        X12SegmentMap<TIA, X12Entity>
    {
        public TIAMap()
        {
            Id = "TIA";
            Name = "Tax Information and Amount";

            Entity(x => x.TaxFieldIdentification, 0);
            Value(x => x.MonetaryAmount02, 1, x=>x.MinLength(1).MaxLength(18));
            Value(x => x.FixedFormatInformation, 2, x=>x.MinLength(1).MaxLength(80));
            Value(x => x.Quantity, 3, x=>x.MinLength(1).MaxLength(15));
            Entity(x => x.CompositeUnitOfMeasure, 4);
            Value(x => x.PercentageAsDecimal, 5, x=>x.MinLength(1).MaxLength(10));
            Value(x => x.MonetaryAmount07, 6, x=>x.MinLength(1).MaxLength(18));
        }
    }
}