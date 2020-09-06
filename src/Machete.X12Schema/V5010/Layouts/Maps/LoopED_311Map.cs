namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopED_311Map :
        X12LayoutMap<LoopED_311, X12Entity>
    {
        public LoopED_311Map()
        {
            Id = "Loop_ED_311";
            Name = "Loop ED";
            
            Segment(x => x.EquipmentDescription, 0);
            Segment(x => x.SealNumbers, 1);
            Segment(x => x.CrossReferenceEquipment, 2);
            Segment(x => x.Measurement, 3);
            Segment(x => x.BeyondRouting, 4);
        }
    }
}