namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T8310Map :
        X12LayoutMap<T831, X12Entity>
    {
        public T8310Map()
        {
            Id = "T831";
            Name = "831 Application Control Totals";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningSegment, 2);
            Segment(x => x.DateOrTimeReference, 3);
            Segment(x => x.ExtendedReferenceInformation, 4);
            Segment(x => x.Trace, 5);
            Segment(x => x.QuantityInformation, 6);
            Layout(x => x.LoopAMT, 7);
            Segment(x => x.TransactionSetTrailer, 8);
            Segment(x => x.FunctionalGroupTrailer, 9);
        }
    }
}