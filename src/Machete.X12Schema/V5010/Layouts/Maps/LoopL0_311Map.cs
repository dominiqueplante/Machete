namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopL0_311Map :
        X12LayoutMap<LoopL0_311, X12Entity>
    {
        public LoopL0_311Map()
        {
            Id = "Loop_L0_311";
            Name = "Loop L0";
            
            Segment(x => x.LineItemQuantityAndWeight, 0);
            Segment(x => x.DescriptionMarksAndNumbers, 1);
            Segment(x => x.Measurement, 2);
            Segment(x => x.ExportLicense, 3);
            Segment(x => x.ImportLicense, 4);
        }
    }
}