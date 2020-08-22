namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0200_204Map :
        X12LayoutMap<Loop0200_204, X12Entity>
    {
        public Loop0200_204Map()
        {
            Id = "Loop_0200_204";
            Name = "Loop 0200";
            
            Segment(x => x.EquipmentDetails, 0);
            Segment(x => x.AccessorialEquipmentDetails, 1);
            Segment(x => x.AdditionalEquipmentDetails, 2);
            Segment(x => x.Measurements, 3);
            Segment(x => x.SealNumbers, 4);
        }
    }
}