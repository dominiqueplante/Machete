namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T213 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<B11> BeginningShipmentStatusInquiry { get; }
        
        Segment<C3> CurrencyIdentifier { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        Segment<L10> WeightInformation { get; }
        
        LayoutList<Loop0100_213> Loop0100 { get; }
        
        SegmentList<K2> AdministrativeMessage { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}