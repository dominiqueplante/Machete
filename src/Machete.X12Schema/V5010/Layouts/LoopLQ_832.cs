namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLQ_832 :
        X12Layout
    {
        SegmentList<LQ> IndustryCodeIdentification { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
        
        SegmentList<EFI> ElectronicFormatIdentification { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        LayoutList<LoopPID_832> LoopLQ { get; }
    }
}