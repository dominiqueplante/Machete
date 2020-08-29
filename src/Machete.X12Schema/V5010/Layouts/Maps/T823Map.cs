namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T823Map :
        X12LayoutMap<T823, X12Entity>
    {
        public T823Map()
        {
            Id = "T823";
            Name = "823 Lockbox";

            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Layout(x => x.LoopN1, 2);
            Segment(x => x.Trace, 3);
            Segment(x => x.DateOrTimeReference, 4);
            Layout(x => x.LoopDEP, 5);
            Segment(x => x.TransactionSetTrailer, 6);
            Segment(x => x.FunctionalGroupTrailer, 7);
        }
    }
}