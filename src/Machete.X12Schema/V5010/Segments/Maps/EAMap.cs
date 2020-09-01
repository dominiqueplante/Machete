namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class EAMap :
        X12SegmentMap<EA, X12Entity>
    {
        public EAMap()
        {
            Id = "EA";
            Name = "Equipment Attributes";
            
            Value(x => x.EquipmentAttributeCode, 1, x => x.MinLength(2).MaxLength(3).IsRequired());
            Entity(x => x.CompositeUnitOfMeasure, 2);
            Value(x => x.Quantity, 5, x => x.MinLength(1).MaxLength(15));
        }
    }
}