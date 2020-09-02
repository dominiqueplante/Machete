namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G3Map :
        X12SegmentMap<G3, X12Entity>
    {
        public G3Map()
        {
            Id = "G3";
            Name = "Compensation Information";
            
            Value(x => x.CompensationPaid, 1, x => x.MinLength(2).MaxLength(5));
            Value(x => x.TotalCompensationAmount, 2, x => x.MinLength(3).MaxLength(10).IsRequired());
            Value(x => x.Name, 3, x => x.MinLength(1).MaxLength(60).IsRequired());
            Value(x => x.BusinessTransactionStatus, 4, x => x.MinLength(1).MaxLength(3));
            Value(x => x.MonetaryAmount, 5, x => x.MinLength(1).MaxLength(18));
            Value(x => x.CompensationQualifier, 6, x => x.FixedLength(2));
        }
    }
}