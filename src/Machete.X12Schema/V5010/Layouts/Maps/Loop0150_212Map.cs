namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0150_212Map :
        X12LayoutMap<Loop0150_212, X12Entity>
    {
        public Loop0150_212Map()
        {
            Id = "Loop_0150_212";
            Name = "Loop 0150";
            
            Segment(x => x.ShipmentStatusDetails, 0);
            Segment(x => x.DateOrTime, 1);
            Segment(x => x.EquipmentShipmentOrRealPropertyLocation, 2);
            Layout(x => x.Loop0160, 3);
        }
    }
}