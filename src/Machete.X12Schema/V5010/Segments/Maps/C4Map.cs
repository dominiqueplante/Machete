namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class C4Map :
        X12SegmentMap<C4, X12Entity>
    {
        public C4Map()
        {
            Id = "C4";
            Name = "Alternate Amount Due";
            
            Value(x => x.CurrencyCode, 1, x => x.FixedLength(3).IsRequired());
            Value(x => x.NetAmountDue, 2, x => x.MinLength(1).MaxLength(12).IsRequired());
        }
    }
}