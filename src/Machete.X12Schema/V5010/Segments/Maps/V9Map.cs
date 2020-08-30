namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class V9Map :
        X12SegmentMap<V9, X12Entity>
    {
        public V9Map()
        {
            Id = "V9";
            Name = "Event Detail";
            
            Value(x => x.EventCode, 1, x => x.FixedLength(3).IsRequired());
            Value(x => x.Event, 2, x => x.MinLength(1).MaxLength(25));
            Value(x => x.Date, 3, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.LongDate;
            });
            Value(x => x.Time, 4, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.CityName, 5, x => x.MinLength(2).MaxLength(30));
            Value(x => x.StateOrProvinceCode, 6, x => x.FixedLength(2));
            Value(x => x.CountryCode, 7, x => x.MinLength(2).MaxLength(3));
            Value(x => x.StatusReasonCode, 83, x => x.FixedLength(3));
            Value(x => x.StandardPointLocationCode1, 9, x => x.MinLength(6).MaxLength(9));
            Value(x => x.Quantity1, 10, x => x.MinLength(1).MaxLength(15));
            Value(x => x.TrainDelayReasonCode, 11, x => x.MinLength(2).MaxLength(3));
            Value(x => x.FreeformInformation, 12, x => x.MinLength(1).MaxLength(30));
            Value(x => x.TimeCode, 13, x => x.FixedLength(2));
            Value(x => x.Quantity2, 14, x => x.MinLength(1).MaxLength(15));
            Value(x => x.StandardPointLocationCode2, 15, x => x.MinLength(6).MaxLength(9));
            Value(x => x.TotalEquipment1, 16, x => x.MinLength(1).MaxLength(3));
            Value(x => x.TotalEquipment2, 17, x => x.MinLength(1).MaxLength(3));
            Value(x => x.TotalEquipment3, 18, x => x.MinLength(1).MaxLength(3));
            Value(x => x.Weight, 19, x => x.MinLength(1).MaxLength(10));
            Value(x => x.Length, 20, x => x.MinLength(1).MaxLength(8));
        }
    }
}