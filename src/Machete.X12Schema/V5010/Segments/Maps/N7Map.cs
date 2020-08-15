namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class N7Map :
        X12SegmentMap<N7, X12Entity>
    {
        public N7Map()
        {
            Id = "N7";
            Name = "Equipment Details";
            
            Value(x => x.EquipmentInitial, 1, x => x.MinLength(1).MaxLength(4));
            Value(x => x.EquipmentNumber, 2, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Weight, 3, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightQualifier, 4, x => x.MinLength(1).MaxLength(2));
            Value(x => x.TareWeight, 5, x => x.MinLength(3).MaxLength(8));
            Value(x => x.WeightAllowance, 6, x => x.MinLength(2).MaxLength(6));
            Value(x => x.Dunnage, 7, x => x.MinLength(1).MaxLength(6));
            Value(x => x.Volume, 8, x => x.MinLength(1).MaxLength(8));
            Value(x => x.VolumeUnitQualifier, 9, x => x.FixedLength(1));
            Value(x => x.OwnershipCode, 10, x => x.FixedLength(1));
            Value(x => x.EquipmentDescriptionCode, 11, x => x.FixedLength(2));
            Value(x => x.StandardCarrierAlphaCode1, 12, x => x.MinLength(2).MaxLength(4));
            Value(x => x.TemperatureControl, 13, x => x.MinLength(3).MaxLength(6));
            Value(x => x.Position, 14, x => x.MinLength(1).MaxLength(3));
            Value(x => x.EquipmentLength, 15, x => x.MinLength(4).MaxLength(5));
            Value(x => x.TareQualifierCode, 16, x => x.FixedLength(1));
            Value(x => x.WeightUnitCode, 17, x => x.FixedLength(1));
            Value(x => x.EquipmentNumberCheckDigit, 18, x => x.FixedLength(1));
            Value(x => x.TypeOfServiceCode, 19, x => x.FixedLength(2));
            Value(x => x.Height, 20, x => x.MinLength(1).MaxLength(8));
            Value(x => x.Width, 21, x => x.MinLength(1).MaxLength(8));
            Value(x => x.EquipmentType, 22, x => x.FixedLength(4));
            Value(x => x.StandardCarrierAlphaCode2, 23, x => x.MinLength(2).MaxLength(4));
            Value(x => x.CarTypeCode, 24, x => x.MinLength(1).MaxLength(4));
        }
    }
}