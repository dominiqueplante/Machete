namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class ICMap :
        X12SegmentMap<IC, X12Entity>
    {
        public ICMap()
        {
            Id = "IC";
            Name = "Intermodal Chassis Equipment";
            
            Value(x => x.EquipmentInitial, 1, x => x.MinLength(1).MaxLength(4).IsRequired());
            Value(x => x.EquipmentNumber, 2, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.TareWeight, 3, x => x.MinLength(3).MaxLength(8));
            Value(x => x.TareQualifierCode, 4, x => x.FixedLength(2));
            Value(x => x.StandardCarrierAlphaCode1, 5, x => x.MinLength(2).MaxLength(4));
            Value(x => x.EquipmentLength, 6, x => x.MinLength(4).MaxLength(5));
            Value(x => x.StandardCarrierAlphaCode2, 7, x => x.MinLength(2).MaxLength(4));
            Value(x => x.ChassisType, 8, x => x.FixedLength(2));
            Value(x => x.EquipmentNumberCheckDigit, 9, x => x.FixedLength(1));
        }
    }
}