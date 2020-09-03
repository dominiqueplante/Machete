namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class IMAMap :
        X12SegmentMap<IMA, X12Entity>
    {
        public IMAMap()
        {
            Id = "IMA";
            Name = "Interchange Move Authority";
            
            Value(x => x.MovementAuthorityCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.StandardCarrierAlphaCode, 2, x => x.MinLength(2).MaxLength(4));
            Value(x => x.TariffApplicationCode1, 3, x => x.FixedLength(1));
            Value(x => x.TariffApplicationCode2, 4, x => x.FixedLength(1));
        }
    }
}