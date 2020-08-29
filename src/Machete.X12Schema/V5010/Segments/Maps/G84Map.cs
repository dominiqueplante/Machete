namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G84Map :
        X12SegmentMap<G84, X12Entity>
    {
        public G84Map()
        {
            Id = "G84";
            Name = "Delivery/Return Record of Totals";
            
            Value(x => x.Quantity, 1, x => x.MinLength(1).MaxLength(15));
            Value(x => x.TotalInvoiceAmount, 2, x => x.MinLength(1).MaxLength(10));
            Value(x => x.TotalDepositDollarAmount, 3, x => x.MinLength(1).MaxLength(6));
        }
    }
}