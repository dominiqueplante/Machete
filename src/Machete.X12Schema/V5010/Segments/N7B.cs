namespace Machete.X12Schema.V5010
{
    using X12;


    public interface N7B :
        X12Segment
    {
        Value<int> NumberOfTankCompartments { get; }
        
        Value<string> LoadingOrDischargeLocationCode { get; }
        
        Value<string> VesselMaterialCode { get; }
        
        Value<string> GasketTypeCode { get; }
        
        Value<string> TrailerLiningTypeCode { get; }
        
        Value<string> ReferenceIdentification { get; }
    }
}