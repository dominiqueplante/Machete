namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class AT7Map :
        X12SegmentMap<AT7, X12Entity>
    {
        public AT7Map()
        {
            Id = "AT7";
            Name = "Shipment Status Details";
            
            Value(x => x.ShipmentStatusIndicator, 1, x => x.FixedLength(2));
            Value(x => x.ShipmentStatusOrAppointmentReasonCode1, 2, x => x.FixedLength(2));
            Value(x => x.ShipmentAppointmentStatusCode, 3, x => x.FixedLength(2));
            Value(x => x.ShipmentStatusOrAppointmentReasonCode2, 4, x => x.FixedLength(2));
            Value(x => x.Date, 5, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Time, 6, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.TimeCode, 7, x => x.FixedLength(2));
        }
    }
}