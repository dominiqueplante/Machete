namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class NAMap :
        X12SegmentMap<NA, X12Entity>
    {
        public NAMap()
        {
            Id = "NA";
            Name = "Cross-Reference Equipment";
            
            Value(x => x.ReferenceIdentificationQualifier, 1, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 2, x => x.MinLength(1).MaxLength(50));
            Value(x => x.EquipmentInitial, 3, x => x.MinLength(1).MaxLength(4).IsRequired());
            Value(x => x.EquipmentNumber, 4, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.CrossReferenceTypeCode, 5, x => x.FixedLength(1));
            Value(x => x.Position, 6, x => x.MinLength(1).MaxLength(3));
            Value(x => x.StandardCarrierAlphaCode1, 7, x => x.MinLength(2).MaxLength(4));
            Value(x => x.EquipmentLength, 8, x => x.MinLength(4).MaxLength(5));
            Value(x => x.StandardCarrierAlphaCode2, 9, x => x.MinLength(2).MaxLength(4));
            Value(x => x.ChassisType, 10, x => x.FixedLength(2));
            Value(x => x.YesNoConditionOrResponseCode, 11, x => x.FixedLength(1));
            Value(x => x.EquipmentNumberCheckDigit, 12, x => x.FixedLength(1));
        }
    }
}