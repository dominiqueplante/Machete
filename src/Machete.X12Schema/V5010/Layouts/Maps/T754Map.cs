namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T754Map :
        X12LayoutMap<T754, X12Entity>
    {
        public T754Map()
        {
            Id = "T754";
            Name = "754 Routing Instructions";

            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningSegment, 2);
            Segment(x => x.AdministrativeCommunicationsContact, 3);
            Layout(x => x.Loop0100, 4);
            Layout(x => x.Loop0200, 5);
            Segment(x => x.TransactionSetTrailer, 6);
            Segment(x => x.FunctionalGroupTrailer, 7);
        }
    }
}