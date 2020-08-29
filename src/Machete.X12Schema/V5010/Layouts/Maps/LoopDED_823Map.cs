namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopDED_823Map :
        X12LayoutMap<LoopDED_823, X12Entity>
    {
        public LoopDED_823Map()
        {
            Id = "Loop_DED_823";
            Name = "Loop DED";
            
            Segment(x => x.Deductions, 0);
        }
    }
}