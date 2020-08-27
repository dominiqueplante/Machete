namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G43Map :
        X12SegmentMap<G43, X12Entity>
    {
        public G43Map()
        {
            Id = "G43";
            Name = "Promotion/Price List Area";
            
            Value(x => x.MarketAreaCodeQualifier, 1, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.MarketAreaCodeIdentifier, 2, x => x.MinLength(1).MaxLength(13));
            Value(x => x.Description, 3, x => x.MinLength(1).MaxLength(80));
            Value(x => x.ClassOfTradeCode, 4, x=> x.FixedLength(2));
        }
    }
}