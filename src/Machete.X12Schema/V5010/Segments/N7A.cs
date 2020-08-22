namespace Machete.X12Schema.V5010
{
    using X12;


    public interface N7A :
        X12Segment
    {
        Value<string> LoadOrDeviceCode { get; }
        
        Value<decimal> Length { get; }
        
        Value<decimal> Diameter1 { get; }
        
        Value<string> HoseTypeCode { get; }
        
        Value<decimal> Diameter2 { get; }
        
        Value<decimal> Diameter3 { get; }
        
        Value<string> InletOrOutletMaterialTypeCode { get; }
        
        Value<string> InletOrOutletFittingTypeCode { get; }
        
        Value<string> MiscellaneousEquipmentCode { get; }
    }
}