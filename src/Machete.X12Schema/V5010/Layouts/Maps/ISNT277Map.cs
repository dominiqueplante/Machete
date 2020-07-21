namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class ISNT277Map :
        X12LayoutMap<ISNT277, X12Entity>
    {
        public ISNT277Map()
        {
            Id = "277";
            Name = "Healthcare Claim Request for Additional Information";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1, x => x.IsRequired());
            Segment(x => x.BeginningOfHierarchicalTransaction, 2, x => x.IsRequired());
            Layout(x => x.Loop2000A, 3);
            Layout(x => x.Loop2000B, 4);
            Layout(x => x.Loop2000C, 5);
            Layout(x => x.Loop2000D, 6);
            Segment(x => x.TransactionSetTrailer, 7, x => x.IsRequired());
            Segment(x => x.FunctionalGroupTrailer, 8);
        }
    }
}