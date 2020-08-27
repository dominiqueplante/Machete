namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPID_832Map :
        X12LayoutMap<LoopPID_832, X12Entity>
    {
        public LoopPID_832Map()
        {
            Id = "Loop_PID_832";
            Name = "Loop PID";
            
            Segment(x => x.ProductOrItemDescription, 0);
            Segment(x => x.Measurements, 1);
            Segment(x => x.Text, 2);
        }
    }
}