namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class P2Map :
        X12SegmentMap<P2, X12Entity>
    {
        public P2Map()
        {
            Id = "P2";
            Name = "Delivery Date Information";
            
            Value(x => x.PickupOrDeliveryCode, 1, x => x.MinLength(1).MaxLength(2));
            Value(x => x.DeliveryDate, 2, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.LongDate;
            });
            Value(x => x.DateOrTimeQualifier, 3, x => x.FixedLength(3).IsRequired());
        }
    }
}