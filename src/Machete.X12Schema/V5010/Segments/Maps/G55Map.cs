namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G55Map :
        X12SegmentMap<G55, X12Entity>
    {
        public G55Map()
        {
            Id = "G55";
            Name = "Item Characteristics - Consumer Unit";
            
            Value(x => x.ProductOrServiceIdQualifier1, 1, x=> x.FixedLength(2).IsRequired());
            Value(x => x.ProductOrServiceId1, 2, x => x.MinLength(1).MaxLength(48).IsRequired());
            Value(x => x.ProductOrServiceIdQualifier2, 3, x=> x.FixedLength(2));
            Value(x => x.ProductOrServiceId2, 4, x => x.MinLength(1).MaxLength(48));
            Value(x => x.Height, 5, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode1, 6, x=> x.FixedLength(2));
            Value(x => x.Width, 7, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode2, 8, x=> x.FixedLength(2));
            Value(x => x.Length, 9, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode3, 10, x=> x.FixedLength(2));
            Value(x => x.Volume, 11, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode4, 12, x=> x.FixedLength(2));
            Value(x => x.Pack, 13, x => x.MinLength(1).MaxLength(6));
            Value(x => x.Size, 14, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode5, 15, x=> x.FixedLength(2));
            Value(x => x.CashRegisterItemDescription1, 16, x => x.MinLength(1).MaxLength(20));
            Value(x => x.CashRegisterItemDescription2, 17, x => x.MinLength(1).MaxLength(20));
            Value(x => x.CouponFamilyCode, 18, x=> x.FixedLength(3));
            Value(x => x.DatedProductNumberOfDays, 19, x => x.MinLength(1).MaxLength(4));
            Value(x => x.DepositValues, 20, x => x.MinLength(1).MaxLength(8));
            Value(x => x.YesNoConditionOrResponseCode, 21, x=> x.FixedLength(1));
            Value(x => x.Color, 22, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitWeight1, 23, x => x.MinLength(1).MaxLength(8));
            Value(x => x.WeightQualifier1, 24, x => x.MinLength(1).MaxLength(2));
            Value(x => x.WeightUnitCode1, 25, x=> x.FixedLength(1));
            Value(x => x.UnitWeight2, 26, x => x.MinLength(1).MaxLength(8));
            Value(x => x.WeightQualifier2, 27, x => x.MinLength(1).MaxLength(2));
            Value(x => x.WeightUnitCode2, 28, x=> x.FixedLength(1));
            Value(x => x.ProductOrServiceIdQualifier3, 29, x=> x.FixedLength(2));
            Value(x => x.ProductOrServiceId3, 30, x => x.MinLength(1).MaxLength(48));
            Value(x => x.FreeformDescription, 31, x => x.MinLength(1).MaxLength(45));
            Value(x => x.InnerPack, 32, x => x.MinLength(1).MaxLength(6));
            Value(x => x.PackagingCode, 33, x => x.MinLength(3).MaxLength(5));
        }
    }
}