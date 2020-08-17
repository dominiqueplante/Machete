namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class C3Map :
        X12SegmentMap<C3, X12Entity>
    {
        public C3Map()
        {
            Id = "C3";
            Name = "Currency Identifier";
            
            Value(x => x.CurrencyCode1, 1, x => x.FixedLength(3).IsRequired());
            Value(x => x.ExchangeRate, 2, x => x.MinLength(4).MaxLength(10));
            Value(x => x.CurrencyCode2, 3, x => x.FixedLength(3));
            Value(x => x.CurrencyCode3, 4, x => x.FixedLength(3));
        }
    }
}