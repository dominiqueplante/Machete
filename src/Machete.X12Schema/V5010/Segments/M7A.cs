namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface M7A :
        X12Segment
    {
        Value<string> SealNumber1 { get; }
        
        Value<string> SealNumber2 { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> EntityIdentifierCode { get; }
        
        Value<string> Name { get; }
        
        Value<string> Description { get; }
    }
}