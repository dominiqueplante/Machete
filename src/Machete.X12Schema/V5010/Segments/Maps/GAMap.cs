namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class GAMap :
        X12SegmentMap<GA, X12Entity>
    {
        public GAMap()
        {
            Id = "GA";
            Name = "Canadian Grain Information";
            
            Value(x => x.FumigatedOrCleanedIndicator, 1, x => x.FixedLength(1));
            Value(x => x.CommodityCode, 2, x => x.MinLength(1).MaxLength(30));
            Value(x => x.InspectedOrWeightedIndicatorCode, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.ReferenceIdentificationQualifier, 4, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 5, x => x.MinLength(1).MaxLength(50));
            Value(x => x.Week, 6, x => x.FixedLength(6));
            Value(x => x.UnloadTerminalElevatorCode, 7, x => x.MinLength(3).MaxLength(4));
            Value(x => x.Date, 8, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Number, 9, x => x.MinLength(1).MaxLength(9));
            Value(x => x.MachineSeparableIndicatorCode, 10, x => x.FixedLength(2));
            Value(x => x.CanadianWheatBoardMarketingClassCode, 11, x => x.FixedLength(1));
            Value(x => x.CanadianWheatBoardMarketingClassTypeCode, 12, x => x.FixedLength(1));
            Value(x => x.YesNoConditionOrResponseCode1, 13, x => x.FixedLength(1));
            Value(x => x.LocationIdentifier, 14, x => x.MinLength(1).MaxLength(30));
            Value(x => x.StateOrProvinceCode, 15, x => x.FixedLength(2));
            Value(x => x.PercentQualifier, 16, x => x.MinLength(1).MaxLength(2));
            Value(x => x.PercentageAsDecimal, 17, x => x.MinLength(1).MaxLength(10));
            Value(x => x.YesNoConditionOrResponseCode2, 18, x => x.FixedLength(1));
        }
    }
}