namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLH1_417 :
        X12Layout
    {
        Segment<LH1> HazardousIdentificationInformation { get; }
        
        SegmentList<LH2> HazardousClassificationInformation { get; }
        
        SegmentList<LH3> HazardousMaterialShippingName { get; }
        
        SegmentList<LFH> FreeformHazardousMaterialInformation { get; }
        
        SegmentList<LEP> EPARequiredData { get; }
        
        SegmentList<LH4> CanadianDangerousRequirements { get; }
        
        SegmentList<LHT> TransborderDangerousRequirements { get; }
        
        SegmentList<LHR> HazardousMaterialIdentifyingReferenceNumbers { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        LayoutList<LoopN1_4_417> LoopN1 { get; }
    }
}