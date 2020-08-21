namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class MS2Map :
        X12SegmentMap<MS2, X12Entity>
    {
        public MS2Map()
        {
            Id = "MS2";
            Name = "Equipment or Container Owner and Type";
            
            Value(x => x.StandardCarrierAlphaCode, 1, x => x.MinLength(2).MaxLength(4));
            Value(x => x.EquipmentNumber, 2, x => x.MinLength(1).MaxLength(15));
            Value(x => x.EquipmentDescriptionCode, 3, x => x.FixedLength(2));
            Value(x => x.EquipmentNumberCheckDigit, 4, x => x.FixedLength(1));
        }
    }
}