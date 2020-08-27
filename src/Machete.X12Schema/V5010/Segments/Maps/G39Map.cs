namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G39Map :
        X12SegmentMap<G39, X12Entity>
    {
        public G39Map()
        {
            Id = "G39";
            Name = "Item Characteristics - Vendor's Selling Unit";
            
            Value(x => x.UniversalProductCodeCaseCode, 1, x=> x.FixedLength(12));
            Value(x => x.ProductOrServiceIdQualifier1, 2, x=> x.FixedLength(2));
            Value(x => x.ProductOrServiceId1, 3, x => x.MinLength(1).MaxLength(48));
            Value(x => x.SpecialHandlingCode, 4, x => x.MinLength(2).MaxLength(3));
            Value(x => x.UnitWeight1, 5, x => x.MinLength(1).MaxLength(8));
            Value(x => x.WeightQualifier1, 6, x => x.MinLength(1).MaxLength(2));
            Value(x => x.WeightUnitCode, 7, x=> x.FixedLength(1));
            Value(x => x.Height, 8, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode1, 9, x=> x.FixedLength(2));
            Value(x => x.Width, 10, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode2, 11, x=> x.FixedLength(2));
            Value(x => x.Length, 12, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode3, 13, x=> x.FixedLength(2));
            Value(x => x.Volume, 14, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode4, 15, x=> x.FixedLength(2));
            Value(x => x.PalletBlockAndTiers, 16, x=> x.FixedLength(6));
            Value(x => x.Pack, 17, x => x.MinLength(1).MaxLength(6));
            Value(x => x.Size, 18, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode5, 19, x=> x.FixedLength(2));
            Value(x => x.Color, 20, x => x.MinLength(1).MaxLength(10));
            Value(x => x.OrderSizingFactor, 21, x => x.MinLength(1).MaxLength(10));
            Value(x => x.AlternateTiersPerPallet, 22, x => x.MinLength(1).MaxLength(3));
            Value(x => x.ProductOrServiceIdQualifier2, 23, x=> x.FixedLength(2));
            Value(x => x.ProductOrServiceId2, 24, x => x.MinLength(1).MaxLength(48));
            Value(x => x.WeightQualifier2, 25, x => x.MinLength(1).MaxLength(2));
            Value(x => x.UnitWeight2, 26, x => x.MinLength(1).MaxLength(8));
            Value(x => x.InnerPack, 27, x => x.MinLength(1).MaxLength(6));
            Value(x => x.PackagingCode, 28, x => x.MinLength(3).MaxLength(5));
            Value(x => x.CashRegisterItemDescription, 29, x => x.MinLength(1).MaxLength(20));
        }
    }
}