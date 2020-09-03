namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class S2Map :
        X12SegmentMap<S2, X12Entity>
    {
        public S2Map()
        {
            Id = "S2";
            Name = "Stop-off Address";
            
            Value(x => x.StopSequenceNumber, 1, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.AddressInformation1, 2, x => x.MinLength(1).MaxLength(55).IsRequired());
            Value(x => x.AddressInformation2, 3, x => x.MinLength(1).MaxLength(55));
        }
    }
}