namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class S1Map :
        X12SegmentMap<S1, X12Entity>
    {
        public S1Map()
        {
            Id = "S1";
            Name = "Stop-off Name";
            
            Value(x => x.StopSequenceNumber, 1, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.Name, 2, x => x.MinLength(1).MaxLength(60).IsRequired());
            Value(x => x.IdentificationCodeQualifier, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.IdentificationCode, 4, x => x.MinLength(2).MaxLength(80));
            Value(x => x.StandardCarrierAlphaCode, 5, x => x.MinLength(2).MaxLength(4));
            Value(x => x.AccomplishCode, 6, x => x.FixedLength(1).IsRequired());
        }
    }
}