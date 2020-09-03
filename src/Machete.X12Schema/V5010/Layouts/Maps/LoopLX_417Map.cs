namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLX_417Map :
        X12LayoutMap<LoopLX_417, X12Entity>
    {
        public LoopLX_417Map()
        {
            Id = "Loop_LX_417";
            Name = "Loop LX";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.DescriptionMarksAndNumbers, 1);
            Layout(x => x.LoopL0, 2);
            Segment(x => x.ExportLicense, 3);
        }
    }
}