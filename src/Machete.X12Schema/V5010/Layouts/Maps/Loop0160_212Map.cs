namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0160_212Map :
        X12LayoutMap<Loop0160_212, X12Entity>
    {
        public Loop0160_212Map()
        {
            Id = "Loop_0160_212";
            Name = "Loop 0160";
            
            Segment(x => x.EquipmentOrContainerOwnerAndType, 0);
            Segment(x => x.SealNumbers, 1);
            Segment(x => x.TrailerOrContainerDimensionAndWeight, 2);
        }
    }
}