namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface Q2 :
        X12Segment
    {
        Value<string> VesselCode { get; }
        
        Value<string> CountryCode { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<DateTime> Date3 { get; }
        
        Value<int> LadingQuantity { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> WeightQualifier { get; }
        
        Value<string> FlightOrVoyageNumber { get; }

        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }
        
        Value<string> VesselCodeQualifier { get; }
        
        Value<string> VesselName { get; }
        
        Value<decimal> Volume { get; }
        
        Value<string> VolumeUnitQualifier { get; }
        
        Value<string> WeightUnitCode { get; }
    }
}