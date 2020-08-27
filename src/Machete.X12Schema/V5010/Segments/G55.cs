namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G55 :
        X12Segment
    {
        Value<string> ProductOrServiceIdQualifier1 { get; }
        
        Value<string> ProductOrServiceId1 { get; }
        
        Value<string> ProductOrServiceIdQualifier2 { get; }
        
        Value<string> ProductOrServiceId2 { get; }
        
        Value<decimal> Height { get; }
        
        Value<string> UnitOrBasisForMeasurementCode1 { get; }
        
        Value<decimal> Width { get; }
        
        Value<string> UnitOrBasisForMeasurementCode2 { get; }
        
        Value<decimal> Length { get; }
        
        Value<string> UnitOrBasisForMeasurementCode3 { get; }
        
        Value<decimal> Volume { get; }
        
        Value<string> UnitOrBasisForMeasurementCode4 { get; }
        
        Value<int> Pack { get; }
        
        Value<decimal> Size { get; }
        
        Value<string> UnitOrBasisForMeasurementCode5 { get; }
        
        Value<string> CashRegisterItemDescription1 { get; }
        
        Value<string> CashRegisterItemDescription2 { get; }
        
        Value<string> CouponFamilyCode { get; }
        
        Value<int> DatedProductNumberOfDays { get; }
        
        Value<decimal> DepositValues { get; }
        
        Value<string> YesNoConditionOrResponseCode { get; }
        
        Value<string> Color { get; }
        
        Value<decimal> UnitWeight1 { get; }
        
        Value<string> WeightQualifier1 { get; }
        
        Value<string> WeightUnitCode1 { get; }
        
        Value<decimal> UnitWeight2 { get; }
        
        Value<string> WeightQualifier2 { get; }
        
        Value<string> WeightUnitCode2 { get; }
        
        Value<string> ProductOrServiceIdQualifier3 { get; }
        
        Value<string> ProductOrServiceId3 { get; }
        
        Value<string> FreeformDescription { get; }
        
        Value<int> InnerPack { get; }
        
        Value<string> PackagingCode { get; }
    }
}