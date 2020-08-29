namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G39 :
        X12Segment
    {
        Value<string> UPCCaseCode { get; }
        
        Value<string> ProductOrServiceIdQualifier1 { get; }
        
        Value<string> ProductOrServiceId1 { get; }
        
        Value<string> SpecialHandlingCode { get; }
        
        Value<decimal> UnitWeight1 { get; }
        
        Value<string> WeightQualifier1 { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<decimal> Height { get; }
        
        Value<string> UnitOrBasisForMeasurementCode1 { get; }
        
        Value<decimal> Width { get; }
        
        Value<string> UnitOrBasisForMeasurementCode2 { get; }
        
        Value<decimal> Length { get; }
        
        Value<string> UnitOrBasisForMeasurementCode3 { get; }
        
        Value<decimal> Volume { get; }
        
        Value<string> UnitOrBasisForMeasurementCode4 { get; }
        
        Value<int> PalletBlockAndTiers { get; }
        
        Value<int> Pack { get; }
        
        Value<decimal> Size { get; }
        
        Value<string> UnitOrBasisForMeasurementCode5 { get; }
        
        Value<string> Color { get; }
        
        Value<decimal> OrderSizingFactor { get; }
        
        Value<string> AlternateTiersPerPallet { get; }
        
        Value<string> ProductOrServiceIdQualifier2 { get; }
        
        Value<string> ProductOrServiceId2 { get; }
        
        Value<string> WeightQualifier2 { get; }
        
        Value<decimal> UnitWeight2 { get; }
        
        Value<int> InnerPack { get; }
        
        Value<string> PackagingCode { get; }
        
        Value<string> CashRegisterItemDescription { get; }
    }
}