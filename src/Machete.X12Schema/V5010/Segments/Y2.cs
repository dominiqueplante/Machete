namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Y2 :
        X12Segment
    {
        Value<int> NumberOfContainers { get; }
        
        Value<string> ContainerTypeRequestCode { get; }
        
        Value<string> TypeOfServiceCode { get; }
        
        Value<string> EquipmentType { get; }
        
        Value<string> TransportationMethodCode { get; }
        
        Value<string> IntermodalServiceCode { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> ContainerTermsCode { get; }
        
        Value<string> ContainerTermsCodeQualifier { get; }
        
        Value<int> TotalStopOffs { get; }
    }
}