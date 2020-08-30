namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class N8Map :
        X12SegmentMap<N8, X12Entity>
    {
        public N8Map()
        {
            Id = "N8";
            Name = "Waybill Reference";
            
            Value(x => x.WaybillNumber1, 1, x => x.MinLength(1).MaxLength(6).IsRequired());
            Value(x => x.Date1, 2, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.LongDate;
            });
            Value(x => x.CrossReferenceTypeCode, 3, x => x.FixedLength(1));
            Value(x => x.EquipmentInitial, 4, x => x.MinLength(1).MaxLength(4));
            Value(x => x.EquipmentNumber, 5, x => x.MinLength(1).MaxLength(15));
            Value(x => x.WaybillNumber2, 6, x => x.MinLength(1).MaxLength(6));
            Value(x => x.Date2, 7, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.LongDate;
            });
            Value(x => x.CityName, 8, x => x.MinLength(2).MaxLength(30));
            Value(x => x.StateOrProvinceCode, 9, x => x.FixedLength(2));
            Value(x => x.StandardCarrierAlphaCode, 10, x => x.MinLength(2).MaxLength(4));
            Value(x => x.FreightStationAccountingCode, 11, x => x.MinLength(1).MaxLength(5));
        }
    }
}