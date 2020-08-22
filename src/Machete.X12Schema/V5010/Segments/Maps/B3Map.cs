namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class B3Map :
        X12SegmentMap<B3, X12Entity>
    {
        public B3Map()
        {
            Id = "B3";
            Name = "Beginning Segment for Carrier's Invoice";
            
            Value(x => x.ShipmentQualifier, 1, x => x.FixedLength(1));
            Value(x => x.InvoiceNumber, 2, x => x.MinLength(1).MaxLength(22));
            Value(x => x.ShipmentIdentificationNumber, 3, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ShipmentMethodOfPayment, 4, x => x.MinLength(1).MaxLength(50));
            Value(x => x.WeightUnitCode, 5, x => x.FixedLength(1));
            Value(x => x.Date1, 6, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.NetAmountDue, 7, x => x.MinLength(1).MaxLength(12));
            Value(x => x.CorrectionIndicator, 8, x => x.FixedLength(2));
            Value(x => x.DeliveryDate, 9, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.DateOrTimeQualifier, 10, x => x.FixedLength(3));
            Value(x => x.StandardCarrierAlphaCode, 11, x => x.MinLength(2).MaxLength(4));
            Value(x => x.Date2, 12, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.TariffServiceCode, 13, x => x.FixedLength(2));
            Value(x => x.TransportationTermsCode, 14, x => x.FixedLength(3));
        }
    }
}