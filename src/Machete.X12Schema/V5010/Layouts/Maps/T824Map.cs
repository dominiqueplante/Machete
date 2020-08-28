namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T824Map :
        X12LayoutMap<T824, X12Entity>
    {
        public T824Map()
        {
            Id = "T824";
            Name = "824 Application Advice";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningSegment, 2);
            Layout(x => x.LoopN1, 3);
            Layout(x => x.LoopOTI, 4);
            Segment(x => x.TransactionSetTrailer, 5);
            Segment(x => x.FunctionalGroupTrailer, 6);
        }
    }
}