namespace Machete.X12Schema.V5010
{
    using X12;


    public interface IMA :
        X12Segment
    {
        Value<string> MovementAuthorityCode { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<int> TariffApplicationCode1 { get; }
        
        Value<int> TariffApplicationCode2 { get; }
    }
}