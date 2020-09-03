namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class BLMap :
        X12SegmentMap<BL, X12Entity>
    {
        public BLMap()
        {
            Id = "BL";
            Name = "Billing Information";
            
            Value(x => x.RebillReasonCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.FreightStationAccountingCode1, 2, x => x.MinLength(1).MaxLength(5));
            Value(x => x.FreightStationAccountingCode2, 3, x => x.MinLength(1).MaxLength(5));
            Value(x => x.StandardPointLocationCode1, 4, x => x.MinLength(6).MaxLength(9));
            Value(x => x.CityName1, 5, x => x.MinLength(2).MaxLength(30));
            Value(x => x.StateOrProvinceCode1, 6, x => x.FixedLength(2));
            Value(x => x.CountryCode1, 7, x => x.MinLength(2).MaxLength(3));
            Value(x => x.StandardPointLocationCode2, 8, x => x.MinLength(6).MaxLength(9));
            Value(x => x.CityName2, 9, x => x.MinLength(2).MaxLength(30));
            Value(x => x.StateOrProvinceCode2, 10, x => x.FixedLength(2));
            Value(x => x.CountryCode2, 11, x => x.MinLength(2).MaxLength(3));
            Value(x => x.StandardCarrierAlphaCode1, 12, x => x.MinLength(2).MaxLength(4));
            Value(x => x.StandardCarrierAlphaCode2, 13, x => x.MinLength(2).MaxLength(4));
            Value(x => x.StandardCarrierAlphaCode3, 14, x => x.MinLength(2).MaxLength(4));
            Value(x => x.StandardCarrierAlphaCode4, 15, x => x.MinLength(2).MaxLength(4));
            Value(x => x.StandardCarrierAlphaCode5, 16, x => x.MinLength(2).MaxLength(4));
            Value(x => x.StandardCarrierAlphaCode6, 17, x => x.MinLength(2).MaxLength(4));
        }
    }
}