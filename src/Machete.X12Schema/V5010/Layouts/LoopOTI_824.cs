namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopOTI_824 :
        X12Layout
    {
        SegmentList<OTI> OriginalTransactionIdentification { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }

        SegmentList<AMT> MonetaryAmountInformation { get; }
        
        Segment<QTY> QuantityInformation { get; }
        
        SegmentList<NM1> IndividualOrOrganizationalName { get; }

        LayoutList<LoopTED_824> LoopTED { get; }

        LayoutList<LoopLM_824> LoopLM { get; }
    }
}