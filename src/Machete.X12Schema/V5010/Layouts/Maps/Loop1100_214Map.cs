namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop1100_214Map :
        X12LayoutMap<Loop1100_214, X12Entity>
    {
        public Loop1100_214Map()
        {
            Id = "Loop_1100_214";
            Name = "Loop 1100";
            
            Segment(x => x.ShipmentStatusDetails, 0);
            Segment(x => x.EquipmentShipmentOrRealPropertyLocation, 1);
            Segment(x => x.EquipmentOrContainerOwnerAndType, 2);
            Segment(x => x.Remarks, 3);
            Segment(x => x.SealNumbers, 4);
        }
    }
}