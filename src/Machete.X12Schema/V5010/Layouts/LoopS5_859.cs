namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopS5_859 :
        X12Layout
    {
        Segment<S5> StopOffDetails { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get;  }
        
        SegmentList<H6> SpecialServices { get; }
        
        LayoutList<LoopN1_859> LoopN1 { get;  }
    }
}