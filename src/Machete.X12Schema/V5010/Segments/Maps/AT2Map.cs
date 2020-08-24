namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class AT2Map :
        X12SegmentMap<AT2, X12Entity>
    {
        public AT2Map()
        {
            Id = "AT2";
            Name = "Bill of Lading Line Item Detail";
            
            Value(x => x.LadingQuantity1, 1, x => x.MinLength(1).MaxLength(7));
            Value(x => x.PackagingFormCode1, 2, x => x.FixedLength(3));
            Value(x => x.WeightQualifier, 3, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.WeightUnitCode, 4, x => x.FixedLength(1).IsRequired());
            Value(x => x.Weight, 5, x => x.MinLength(1).MaxLength(10).IsRequired());
            Value(x => x.LadingQuantity2, 6, x => x.MinLength(1).MaxLength(7));
            Value(x => x.PackagingFormCode2, 7, x => x.FixedLength(3));
            Value(x => x.YesNoConditionOrResponseCode1, 8, x => x.FixedLength(1));
            Value(x => x.CommodityCode, 9, x => x.MinLength(1).MaxLength(30));
            Value(x => x.FreightClassCode, 10, x => x.MinLength(2).MaxLength(5));
            Value(x => x.YesNoConditionOrResponseCode2, 11, x => x.FixedLength(1));
            Value(x => x.LadingValue, 12, x => x.MinLength(2).MaxLength(9));
        }
    }
}