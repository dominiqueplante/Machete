namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T3Map :
        X12SegmentMap<T3, X12Entity>
    {
        public T3Map()
        {
            Id = "T3";
            Name = "Transit Inbound Route";
            
            Value(x => x.AssignedNumber, 1, x => x.MinLength(1).MaxLength(6).IsRequired());
            Value(x => x.StandardCarrierAlphaCode, 2, x => x.MinLength(2).MaxLength(4).IsRequired());
            Value(x => x.RoutingSequenceCode, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.CityName, 4, x => x.MinLength(2).MaxLength(30));
            Value(x => x.StandardPointLocationCode, 5, x => x.MinLength(6).MaxLength(9));
            Value(x => x.EquipmentInitial, 6, x => x.MinLength(1).MaxLength(4));
            Value(x => x.EquipmentNumber, 7, x => x.MinLength(1).MaxLength(15));
        }
    }
}