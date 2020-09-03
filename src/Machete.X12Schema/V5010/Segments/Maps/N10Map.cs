namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class N10Map :
        X12SegmentMap<N10, X12Entity>
    {
        public N10Map()
        {
            Id = "N10";
            Name = "Quantity and Description";
            
            Value(x => x.Quantity, 1, x => x.MinLength(1).MaxLength(15));
            Value(x => x.FreeformDescription, 2, x => x.MinLength(1).MaxLength(45));
            Value(x => x.MarksAndNumbers, 3, x => x.MinLength(1).MaxLength(48));
            Value(x => x.CommodityCodeQualifier, 4, x => x.MinLength(1).MaxLength(30));
            Value(x => x.CommodityCode, 5, x => x.FixedLength(1));
            Value(x => x.CustomsShipmentValue, 6, x => x.MinLength(2).MaxLength(8));
            Value(x => x.WeightUnitCode, 7, x => x.FixedLength(1));
            Value(x => x.Weight, 8, x => x.MinLength(1).MaxLength(10));
            Value(x => x.ReferenceIdentification, 9, x => x.MinLength(1).MaxLength(50));
            Value(x => x.ManifestUnitCode, 10, x => x.MinLength(1).MaxLength(3));
            Value(x => x.CountryCode1, 11, x => x.MinLength(2).MaxLength(3));
            Value(x => x.CountryCode2, 12, x => x.MinLength(2).MaxLength(3));
            Value(x => x.CurrencyCode, 13, x => x.FixedLength(3));
        }
    }
}