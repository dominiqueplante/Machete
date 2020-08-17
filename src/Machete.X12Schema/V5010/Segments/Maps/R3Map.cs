namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class R3Map :
        X12SegmentMap<R3, X12Entity>
    {
        public R3Map()
        {
            Id = "R3";
            Name = "Route Information - Motor";
            
            Value(x => x.StandardCarrierAlphaCode, 1, x => x.MinLength(2).MaxLength(4).IsRequired());
            Value(x => x.RoutingSequenceCode, 2, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.CityName, 3, x => x.MinLength(2).MaxLength(30));
            Value(x => x.TransportationMethodOrTypeCode, 4, x => x.MinLength(1).MaxLength(2));
            Value(x => x.StandardPointLocationCode, 5, x => x.MinLength(6).MaxLength(9));
            Value(x => x.InvoiceNumber, 6, x => x.MinLength(1).MaxLength(22));
            Value(x => x.Date, 7, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Amount, 8, x => x.MinLength(1).MaxLength(15));
            Value(x => x.FreeformDescription, 9, x => x.MinLength(1).MaxLength(45));
            Value(x => x.ServiceLevelCode1, 10, x => x.FixedLength(2));
            Value(x => x.ServiceLevelCode2, 11, x => x.FixedLength(2));
            Value(x => x.ServiceLevelCode3, 12, x => x.FixedLength(2));
        }
    }
}