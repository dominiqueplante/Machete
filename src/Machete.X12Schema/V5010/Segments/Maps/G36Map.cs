namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G36Map :
        X12SegmentMap<G36, X12Entity>
    {
        public G36Map()
        {
            Id = "G36";
            Name = "Price List Reference";
            
            Value(x => x.PriceListNumber, 1, x => x.MinLength(1).MaxLength(16).IsRequired());
            Value(x => x.PriceListIssueNumber, 2, x => x.MinLength(1).MaxLength(16));
            Value(x => x.Date, 3, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
            });
            Value(x => x.PriceConditionAppliesCode, 4, x=> x.FixedLength(3));
        }
    }
}