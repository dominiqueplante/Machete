namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T315Map :
        X12LayoutMap<T315, X12Entity>
    {
        public T315Map()
        {
            Id = "T315";
            Name = "315 Status Details (Ocean)";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningSegmentForInquiryOrReply, 2);
            Segment(x => x.ExtendedReferenceInformation, 3);
            Segment(x => x.StatusDetails, 4);
            Segment(x => x.ShipmentDetails, 5);
            Layout(x => x.LoopR4, 6);
            Segment(x => x.EventDetail, 7);
            Segment(x => x.TransactionSetTrailer, 8);
            Segment(x => x.FunctionalGroupTrailer, 9);
        }
    }
}