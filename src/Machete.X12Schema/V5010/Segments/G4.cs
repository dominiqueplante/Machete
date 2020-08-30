namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface G4 :
        X12Segment
    {
        Value<string> CityName { get; }
        
        Value<string> StateOrProvinceCode { get; }
        
        Value<string> Name { get; }

        Value<DateTime> Date { get; }

        Value<TimeSpan> Time { get; }
        
        Value<string> ScaleTypeCode { get; }
    }
}