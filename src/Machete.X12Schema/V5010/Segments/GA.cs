namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface GA :
        X12Segment
    {
        Value<string> FumigatedOrCleanedIndicator { get; }
        
        Value<string> CommodityCode { get; }
        
        Value<string> InspectedOrWeightedIndicatorCode { get; }
        
        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }
        
        Value<int> Week { get; }
        
        Value<string> UnloadTerminalElevatorCode { get; }
        
        Value<DateTime> Date { get; }
        
        Value<int> Number { get; }
        
        Value<string> MachineSeparableIndicatorCode { get; }
        
        Value<string> CanadianWheatBoardMarketingClassCode { get; }
        
        Value<string> CanadianWheatBoardMarketingClassTypeCode { get; }
        
        Value<string> YesNoConditionOrResponseCode1 { get; }
        
        Value<string> LocationIdentifier { get; }
        
        Value<string> StateOrProvinceCode { get; }
        
        Value<string> PercentQualifier { get; }
        
        Value<decimal> PercentageAsDecimal { get; }
        
        Value<string> YesNoConditionOrResponseCode2 { get; }
    }
}