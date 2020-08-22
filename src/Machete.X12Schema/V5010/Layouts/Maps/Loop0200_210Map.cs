namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0200_210Map :
        X12LayoutMap<Loop0200_210, X12Entity>
    {
        public Loop0200_210Map()
        {
            Id = "Loop_0200_210";
            Name = "Loop 0200";
            
            Segment(x => x.EquipmentDetails, 0);
            Segment(x => x.SealNumbers, 1);
        }
    }
}