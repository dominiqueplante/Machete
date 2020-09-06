namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class EDMap :
        X12SegmentMap<ED, X12Entity>
    {
        public EDMap()
        {
            Id = "ED";
            Name = "Equipment Description";
            
            Value(x => x.EquipmentInitial, 1, x => x.MinLength(1).MaxLength(4).IsRequired());
            Value(x => x.EquipmentNumber1, 2, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.LoadOrEmptyStatusCode, 3, x => x.FixedLength(1));
            Value(x => x.CommodityCode, 4, x => x.MinLength(1).MaxLength(30));
            Value(x => x.LadingDescription, 5, x => x.MinLength(1).MaxLength(50));
            Value(x => x.WaybillNumber, 6, x => x.MinLength(1).MaxLength(6));
            Value(x => x.EquipmentNumber2, 7, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Date, 8, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
        }
    }
}