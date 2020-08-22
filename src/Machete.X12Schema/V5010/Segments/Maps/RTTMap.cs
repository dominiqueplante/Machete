namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class RTTMap :
        X12SegmentMap<RTT, X12Entity>
    {
        public RTTMap()
        {
            Id = "RTT";
            Name = "Freight Rate Information";
            
            Value(x => x.RateOrValueQualifier, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.FreightRate, 2, x => x.MinLength(1).MaxLength(9).IsRequired());
        }
    }
}