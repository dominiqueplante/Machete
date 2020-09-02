namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopL0_310 :
        X12Layout
    {
        Segment<L0> LineItemQuantityAndWeight { get; }
        
        SegmentList<L5> DescriptionMarksAndNumbers { get; }
        
        LayoutList<LoopL1_310> LoopL1 { get; }
        
        Segment<L7> TariffReference { get; }
        
        Segment<X1> ExportLicense { get; }
        
        Segment<X2> ImportLicense { get; }
        
        LayoutList<LoopC8_310> LoopC8 { get; }
        
        LayoutList<LoopH1_310> LoopH1 { get; }
        
        LayoutList<LoopLH1_310> LoopLH1 { get; }
    }
}