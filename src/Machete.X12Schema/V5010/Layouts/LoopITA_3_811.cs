namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopITA_3_811 :
        X12Layout
    {
        Segment<ITA> AllowanceChargeOrService { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        Segment<AMT> MonetaryAmountInformation { get; }

        SegmentList<SI> ServiceCharacteristicIdentification { get; }
        
        SegmentList<REF> ReferenceInformation { get; }

        Segment<CUR> Currency { get; }
    }
}