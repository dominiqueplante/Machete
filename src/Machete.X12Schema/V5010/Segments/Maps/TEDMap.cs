namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class TEDMap :
        X12SegmentMap<TED, X12Entity>
    {
        public TEDMap()
        {
            Id = "TED";
            Name = "Technical Error Description";
            
            Value(x => x.ApplicationErrorConditionCode, 1, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.FreeformMessage, 2, x => x.MinLength(1).MaxLength(60));
            Value(x => x.SegmentIdCode, 3, x => x.MinLength(2).MaxLength(3));
            Value(x => x.SegmentPositionInTransactionSet, 4, x => x.MinLength(1).MaxLength(10));
            Entity(x => x.PositionInSegment, 5);
            Entity(x => x.ReferenceInSegment, 6);
            Value(x => x.CopyOfBadDataElement, 7, x => x.MinLength(1).MaxLength(99));
            Value(x => x.DataElementNewContent, 8, x => x.MinLength(1).MaxLength(99));
        }
    }
}