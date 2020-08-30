namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class P1Map :
        X12SegmentMap<P1, X12Entity>
    {
        public P1Map()
        {
            Id = "P1";
            Name = "Pickup";
            
            Value(x => x.PickupOrDeliveryCode, 1, x => x.MinLength(1).MaxLength(2));
            Value(x => x.PickupDate, 2, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.LongDate;
            });
            Value(x => x.DateOrTimeQualifier, 3, x => x.FixedLength(3).IsRequired());
            Value(x => x.PickupTime, 4, x =>
            {
                x.FixedLength(4);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.EquipmentInitial, 5, x => x.MinLength(1).MaxLength(4));
            Value(x => x.EquipmentNumber, 6, x => x.MinLength(1).MaxLength(15));
            Value(x => x.NumberOfShipments, 7, x => x.MinLength(1).MaxLength(5));
        }
    }
}