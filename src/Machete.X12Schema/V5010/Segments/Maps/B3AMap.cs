namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class B3AMap :
        X12SegmentMap<B3A, X12Entity>
    {
        public B3AMap()
        {
            Id = "B3A";
            Name = "Invoice Type";
            
            Value(x => x.TransactionTypeCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.NumberOfShipments, 2, x => x.MinLength(1).MaxLength(5));
        }
    }
}