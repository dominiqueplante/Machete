namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class BLRMap :
        X12SegmentMap<BLR, X12Entity>
    {
        public BLRMap()
        {
            Id = "BLR";
            Name = "Transportation Carrier Identification";
            
            Value(x => x.StandardCarrierAlphaCode, 1, x => x.MinLength(2).MaxLength(4).IsRequired());
            Value(x => x.Date, 2, x =>
            {
                x.FixedLength(8);
            });
            Value(x => x.Time, 3, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
            });
        }
    }
}