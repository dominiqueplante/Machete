namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopRMR_823 :
        X12Layout
    {
        Segment<RMR> RemittanceAdviceAccountsReceivableOpenItemReference { get; }
        
        Segment<N1> PartyIdentification { get; }
        
        Segment<CUR> Currency { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        LayoutList<LoopIT1_823> LoopIT1 { get; }
    }
}