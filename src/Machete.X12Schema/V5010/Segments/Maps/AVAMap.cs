namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class AVAMap :
        X12SegmentMap<AVA, X12Entity>
    {
        public AVAMap()
        {
            Id = "AVA";
            Name = "Funds Availability";
            
            Value(x => x.MonetaryAmount, 1, x => x.MinLength(1).MaxLength(18).IsRequired());
            Value(x => x.Availability, 2, x => x.MinLength(1).MaxLength(6).IsRequired());
        }
    }
}