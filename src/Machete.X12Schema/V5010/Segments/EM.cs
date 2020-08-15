namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface EM :
        X12Segment
    {
        Value<string> WeightUnitCode { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> VolumeUnitQualifier { get; }
        
        Value<decimal> Volume { get; }
        
        Value<string> CountryCode { get; }
        
        Value<string> ConstructionType { get; }
        
        Value<DateTime> Date { get; }
    }
}