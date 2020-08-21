namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class B2AMap :
        X12SegmentMap<B2A, X12Entity>
    {
        public B2AMap()
        {
            Id = "B2A";
            Name = "Set Purpose";
            
            Value(x => x.TransactionSetPurpose, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.ApplicationType, 2, x => x.FixedLength(2));
        }
    }
}