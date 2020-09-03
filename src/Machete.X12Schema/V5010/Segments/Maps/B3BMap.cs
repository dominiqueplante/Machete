namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class B3BMap :
        X12SegmentMap<B3B, X12Entity>
    {
        public B3BMap()
        {
            Id = "B3B";
            Name = "Beginning Segment for Rail Carrier's Invoice";
            
            Value(x => x.InvoiceNumber, 1, x => x.MinLength(1).MaxLength(22).IsRequired());
            Value(x => x.ShipmentMethodOfPayment, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.Date1, 3, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.LongDate;
            });
            Value(x => x.NetAmountDue, 4, x => x.MinLength(1).MaxLength(12).IsRequired());
            Value(x => x.Date2, 5, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.LongDate;
            });
            Value(x => x.StandardCarrierAlphaCode, 6, x => x.MinLength(2).MaxLength(4).IsRequired());
            Value(x => x.TransportationMethodOrTypeCode, 7, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.ShipmentIdentificationNumber, 8, x => x.MinLength(1).MaxLength(30));
            Value(x => x.WeightUnitCode, 9, x => x.FixedLength(1));
            Value(x => x.CorrectionIndicator, 10, x => x.FixedLength(2));
            Value(x => x.CurrencyCode, 11, x => x.FixedLength(3));
        }
    }
}