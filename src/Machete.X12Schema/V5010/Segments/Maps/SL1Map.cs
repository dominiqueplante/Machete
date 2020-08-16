namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class SL1Map :
        X12SegmentMap<SL1, X12Entity>
    {
        public SL1Map()
        {
            Id = "SL1";
            Name = "Tariff Details";
            
            Value(x => x.ServiceLevelCode1, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.TariffNumber, 2, x => x.MinLength(1).MaxLength(7));
            Value(x => x.CommodityCode, 3, x => x.MinLength(1).MaxLength(30));
            Value(x => x.Scale, 4, x => x.MinLength(1).MaxLength(10));
            Value(x => x.Date, 5, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ServiceLevelCode2, 6, x => x.FixedLength(2));
            Value(x => x.ShipmentMethodOfPayment, 7, x => x.FixedLength(2));
            Value(x => x.DataSourceCode, 8, x => x.FixedLength(2));
            Value(x => x.InternationalOrDomesticCode, 9, x => x.FixedLength(1));
        }
    }
}