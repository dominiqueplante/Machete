namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class N8AMap :
        X12SegmentMap<N8A, X12Entity>
    {
        public N8AMap()
        {
            Id = "N8A";
            Name = "Additional Reference Information";
            
            Value(x => x.WaybillCrossReferenceCode, 1, x => x.FixedLength(2));
            Value(x => x.WaybillNumber, 2, x => x.MinLength(1).MaxLength(6));
            Value(x => x.Date, 3, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ReferenceIdentification, 4, x => x.MinLength(1).MaxLength(50));
            Value(x => x.CityName, 5, x => x.MinLength(2).MaxLength(30));
            Value(x => x.StateOrProvinceCode, 6, x => x.FixedLength(2));
            Value(x => x.StandardCarrierAlphaCode, 7, x => x.MinLength(2).MaxLength(4));
            Value(x => x.FreightStationAccountingCode, 8, x => x.MinLength(1).MaxLength(5));
            Value(x => x.EquipmentInitial, 9, x => x.MinLength(1).MaxLength(4));
            Value(x => x.EquipmentNumber, 10, x => x.MinLength(1).MaxLength(15));
        }
    }
}