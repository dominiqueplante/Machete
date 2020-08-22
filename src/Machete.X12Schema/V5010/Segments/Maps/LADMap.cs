namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LADMap :
        X12SegmentMap<LAD, X12Entity>
    {
        public LADMap()
        {
            Id = "LAD";
            Name = "Lading Detail";
            
            Value(x => x.PackagingFormCode, 1, x => x.FixedLength(3));
            Value(x => x.LadingQuantity, 2, x => x.MinLength(1).MaxLength(7));
            Value(x => x.WeightUnitCode1, 3, x => x.FixedLength(1));
            Value(x => x.UnitWeight, 4, x => x.MinLength(1).MaxLength(8));
            Value(x => x.WeightUnitCode2, 5, x => x.FixedLength(1));
            Value(x => x.Weight, 6, x => x.MinLength(1).MaxLength(10));
            Value(x => x.ProductOrServiceIdQualifier1, 7, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId1, 8, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier2, 9, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId2, 10, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier3, 11, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId3, 12, x => x.MinLength(1).MaxLength(48));
            Value(x => x.LadingDescription, 4, x => x.MinLength(1).MaxLength(50));
            Value(x => x.LadingValue, 5, x => x.MinLength(2).MaxLength(9));
        }
    }
}